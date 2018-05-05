using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Consolidation.BackEnd.Startup))]
namespace Consolidation.BackEnd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
