using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CandyCrush.Startup))]
namespace CandyCrush
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
