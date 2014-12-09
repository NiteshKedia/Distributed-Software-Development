<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
        // Code that runs on application startup
        Application["Title"] = "How Do I Use Application Level Events";
        Application["NumberUsers"] = 0;
        Application["ApplicationCounter"] = 0;

    }
    void Application_BeginRequest(object sender, EventArgs e)
    {

    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown

    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs
        HttpContext ctx = HttpContext.Current;
        String appPath = ctx.Request.AppRelativeCurrentExecutionFilePath;
        Exception exception = ctx.Server.GetLastError();

        string errorInfo =
          
           "<br>Message: " + exception.InnerException.Message ;
       
        
        ctx.Response.Write("<h1>Error Page from global.asax!!!</h1>\n");
        ctx.Response.Write("<h2 style=\"color:red;\">" + errorInfo + "</h2>\n");
        ctx.Response.Write("Return to the <a href="+appPath.Split('/')[1]+">" + 
            "Default Page</a>\n");
        // --------------------------------------------------
        // To let the page finish running we clear the error
        // --------------------------------------------------
        ctx.Server.ClearError();

    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started

    }

    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }
       
</script>
