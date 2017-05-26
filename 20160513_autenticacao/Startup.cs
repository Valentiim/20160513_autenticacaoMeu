using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClinicaVeterinaria.Startup))]
namespace ClinicaVeterinaria
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
