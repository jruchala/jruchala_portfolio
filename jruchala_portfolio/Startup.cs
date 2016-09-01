using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jruchala_portfolio.Startup))]
namespace jruchala_portfolio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
