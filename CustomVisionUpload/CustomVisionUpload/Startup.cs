using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomVisionUpload.Startup))]
namespace CustomVisionUpload
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
