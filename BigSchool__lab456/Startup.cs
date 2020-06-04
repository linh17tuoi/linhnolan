using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigSchool__lab456.Startup))]
namespace BigSchool__lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
