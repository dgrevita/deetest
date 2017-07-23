using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(deetestTemplate.Startup))]
namespace deetestTemplate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
