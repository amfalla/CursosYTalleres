using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClasesYTalleres.Startup))]
namespace ClasesYTalleres
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
