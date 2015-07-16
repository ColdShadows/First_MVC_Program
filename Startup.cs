using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(First_MVC_Program.Startup))]
namespace First_MVC_Program
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
