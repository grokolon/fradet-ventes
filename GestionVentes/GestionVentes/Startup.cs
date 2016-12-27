using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GestionVentes.Startup))]
namespace GestionVentes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
