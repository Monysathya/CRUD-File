using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRUD_Upload_file.Startup))]
namespace CRUD_Upload_file
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
