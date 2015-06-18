# MAB.ContextInspector

Easily inspect Session, Application and Cache variables in ASP.NET MVC applications.

## Installing

First, add the NuGet package to your project. Then, add the CSS bundle to the `HEAD` section of your master/layout page HTML:

    @Styles.Render("~/bundles/mab.contextinspector.css")
   
Finally, add the script bundle to the master/layout page just above the closing `<body>` tag:

    @Scripts.Render("~/bundles/mab.contextinspector.js")
    
You're done!
