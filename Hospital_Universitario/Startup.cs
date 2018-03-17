using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hospital_Universitario.Startup))]
namespace Hospital_Universitario
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
