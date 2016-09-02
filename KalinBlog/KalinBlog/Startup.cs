using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KalinBlog.Startup))]
namespace KalinBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
