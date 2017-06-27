using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SpiderSearch.Startup))]
namespace SpiderSearch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
