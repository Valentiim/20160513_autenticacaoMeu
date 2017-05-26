using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_20160513_autenticacao.Startup))]
namespace _20160513_autenticacao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
