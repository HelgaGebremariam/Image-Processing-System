using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IPS.PL.Startup))]
namespace IPS.PL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
