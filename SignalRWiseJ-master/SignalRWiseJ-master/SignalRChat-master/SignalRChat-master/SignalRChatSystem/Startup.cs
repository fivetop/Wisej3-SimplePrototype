using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;

[assembly: OwinStartup(typeof(SignalRChatSystem.Startup))]

namespace SignalRChatSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {   
            ConfigureAuth(app);
            app.UseCors(CorsOptions.AllowAll);
            var hubConfiguration = new HubConfiguration();
            hubConfiguration.EnableDetailedErrors = true;
            app.MapSignalR(hubConfiguration);
        }
    }
}
