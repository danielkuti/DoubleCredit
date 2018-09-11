using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DoubleCredit.Startup))]
namespace DoubleCredit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
