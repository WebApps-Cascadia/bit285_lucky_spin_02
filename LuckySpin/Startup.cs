using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace LuckySpin
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ILuckySpin, Lucky7>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();
            app.UseEndpoints(endpoints => {
                // Added range constraint to the route, although, 
                // this has no effect if the route is like 
                // localhost:#####/?luck=100;
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action}/{luck:int:range(1,9)?}",
                    defaults: new { controller = "Spinner", action = "Index" }
                );
            });
        }
    }
}
