using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vso.io.Startup))]
namespace vso.io
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {            
        }
    }
}
