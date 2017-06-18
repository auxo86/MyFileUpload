using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFileUpload.Startup))]
namespace MyFileUpload
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
