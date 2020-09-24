using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LinqToSQLMvcApplication.Startup))]
namespace LinqToSQLMvcApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
