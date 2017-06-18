<%@ Application Language="C#" %>
<%@ Import Namespace="MyFileUpload" %>
<%@ Import Namespace="System.Web.Optimization" %>
<%@ Import Namespace="System.Web.Routing" %>
<%@ Import Namespace="System.Web.Configuration" %>

<script RunAt="server">

    void Application_Start(object sender, EventArgs e)
    {
        RouteConfig.RegisterRoutes(RouteTable.Routes);
        BundleConfig.RegisterBundles(BundleTable.Bundles);
    }

    void Application_BeginRequest(object sender, EventArgs e)
    {
        HttpRuntimeSection section = (HttpRuntimeSection)ConfigurationManager.GetSection("system.web/httpRuntime");
        int maxFileSize = section.MaxRequestLength * 1024;

        if (Request.ContentLength > maxFileSize)
        {
            Response.Redirect("~/FileTooLarge.aspx");
        }
    }
</script>
