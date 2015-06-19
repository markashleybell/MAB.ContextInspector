//  https://developer.mozilla.org/en-US/docs/Web/API/document.cookie

var MAB = {
    CI: (function () {

        var _getCookie = function (sKey) {
            if (!sKey) { return null; }
            return decodeURIComponent(document.cookie.replace(new RegExp("(?:(?:^|.*;)\\s*" + encodeURIComponent(sKey).replace(/[\-\.\+\*]/g, "\\$&") + "\\s*\\=\\s*([^;]*).*$)|^.*$"), "$1")) || null;
        };

        var _setCookie = function (sKey, sValue, vEnd, sPath, sDomain, bSecure) {
            if (!sKey || /^(?:expires|max\-age|path|domain|secure)$/i.test(sKey)) { return false; }
            var sExpires = "";
            if (vEnd) {
                switch (vEnd.constructor) {
                    case Number:
                        sExpires = vEnd === Infinity ? "; expires=Fri, 31 Dec 9999 23:59:59 GMT" : "; max-age=" + vEnd;
                        break;
                    case String:
                        sExpires = "; expires=" + vEnd;
                        break;
                    case Date:
                        sExpires = "; expires=" + vEnd.toUTCString();
                        break;
                }
            }
            document.cookie = encodeURIComponent(sKey) + "=" + encodeURIComponent(sValue) + sExpires + (sDomain ? "; domain=" + sDomain : "") + (sPath ? "; path=" + sPath : "") + (bSecure ? "; secure" : "");
            return true;
        };

        var _removeItem = function (sKey, sPath, sDomain) {
            if (!this.hasItem(sKey)) { return false; }
            document.cookie = encodeURIComponent(sKey) + "=; expires=Thu, 01 Jan 1970 00:00:00 GMT" + (sDomain ? "; domain=" + sDomain : "") + (sPath ? "; path=" + sPath : "");
            return true;
        };

        var _hasItem = function (sKey) {
            if (!sKey) { return false; }
            return (new RegExp("(?:^|;\\s*)" + encodeURIComponent(sKey).replace(/[\-\.\+\*]/g, "\\$&") + "\\s*\\=")).test(document.cookie);
        };

        var _keys = function () {
            var aKeys = document.cookie.replace(/((?:^|\s*;)[^\=]+)(?=;|$)|^\s*|\s*(?:\=[^;]*)?(?:\1|$)/g, "").split(/\s*(?:\=[^;]*)?;\s*/);
            for (var nLen = aKeys.length, nIdx = 0; nIdx < nLen; nIdx++) { aKeys[nIdx] = decodeURIComponent(aKeys[nIdx]); }
            return aKeys;
        };

        var _toggleClass = function (el, className) {
            if (el.classList) {
                el.classList.toggle(className);
            } else {
                var classes = el.className.split(' ');
                var existingIndex = classes.indexOf(className);

                if (existingIndex >= 0)
                    classes.splice(existingIndex, 1);
                else
                    classes.push(className);

                el.className = classes.join(' ');
            }
        };

        var _syntaxHighlight = function (json) {
            if (json.indexOf('{') != -1)
                json = JSON.stringify(JSON.parse(json), undefined, 4);

            json = json.replace(/&/g, '&amp;').replace(/</g, '&lt;').replace(/>/g, '&gt;');
            return json.replace(/("(\\u[a-zA-Z0-9]{4}|\\[^u]|[^\\"])*"(\s*:)?|\b(true|false|null)\b|-?\d+(?:\.\d*)?(?:[eE][+\-]?\d+)?)/g, function (match) {
                var cls = 'number';
                if (/^"/.test(match)) {
                    if (/:$/.test(match)) {
                        cls = 'key';
                        match = match.replace(/\"/gi, '')
                    } else {
                        cls = 'string';
                    }
                } else if (/true|false/.test(match)) {
                    cls = 'boolean';
                } else if (/null/.test(match)) {
                    cls = 'null';
                }
                return '<span class="' + cls + '">' + match + '</span>';
            });
        };

        var _init = function (standalone) {

            if (!standalone) {
                var container = document.createElement('div');
                container.id = 'mab-contextinspector';
                container.className = 'inspector';

                document.body.appendChild(container);

                var toggle = document.createElement('a');
                toggle.id = 'mab-contextinspector-toggle';
                toggle.text = 'Inspect Context';
                toggle.href = '#';

                document.body.appendChild(toggle);

                toggle.addEventListener('click', function (e) {
                    e.preventDefault();
                    _toggleClass(this, 'open');
                    var container = document.getElementById('mab-contextinspector');
                    _toggleClass(container, 'open');
                });

                var request = new XMLHttpRequest();
                request.open('GET', '/contextinspector/data', true);

                request.onload = function () {
                    if (request.status >= 200 && request.status < 400) {
                        container.innerHTML = request.responseText;

                        var elements = document.getElementsByClassName('value');
                        for (var i = 0; i < elements.length; i++) {
                            elements[i].innerHTML = '<pre>' + _syntaxHighlight(elements[i].innerHTML) + '</pre>';
                        }

                    } else {
                        container.innerHTML = '<p>Context data loading failed.</p>';
                    }
                };

                request.onerror = function () {
                    // There was a connection error of some sort
                };

                request.send();
            } else {
                var elements = document.getElementsByClassName('value');
                for (var i = 0; i < elements.length; i++) {
                    elements[i].innerHTML = '<pre>' + _syntaxHighlight(elements[i].innerHTML) + '</pre>';
                }
            }
        };

        return {
            init: _init
        };
    }())
};

MAB.CI.init(typeof _CI_STANDALONE !== 'undefined');

//if (docCookies.getItem('mab.contextinspector.stayopen') == 1) {
//    inspector.toggle();
//    toggle.toggleClass('open');
//}

//docCookies.setItem('mab.contextinspector.stayopen', 1);