$(function () {
    
    var inspector = $('<div id="mab-contextinspector"><iframe src="/contextinspector" width="100%" height="100%" border="0" frameborder="0"></iframe></div>');
    var toggle = $('<a id="mab-contextinspector-toggle" href="#">Inspect Context</div>');
    $('body').append(inspector).append(toggle);
    toggle.on('click', function (e) {
        e.preventDefault();
        inspector.toggle();
        toggle.toggleClass('open');
    });
});