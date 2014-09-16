# MAB.ContextInspector

Easily inspect Session and Application variables in ASP.NET MVC applications

## Installing

First, add the NuGet package to your project. Then, add the CSS bundle to the `HEAD` section of your master page HTML:

    @Styles.Render("~/bundles/mab.contextinspector.css")
   
Finally, add the script bundle to the master page just above the closing `<body>` tag:

    @Scripts.Render("~/bundles/mab.contextinspector.js")
    
You're done!
