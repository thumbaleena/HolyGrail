using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstASPapp.Startup))]
namespace FirstASPapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
