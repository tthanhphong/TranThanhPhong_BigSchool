using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TranThanhPhong_BigSchool.Startup))]
namespace TranThanhPhong_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
