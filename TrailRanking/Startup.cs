using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrailRanking.Startup))]
namespace TrailRanking
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
