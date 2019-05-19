using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(The_Cinema_Bucket.Startup))]
namespace The_Cinema_Bucket
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
