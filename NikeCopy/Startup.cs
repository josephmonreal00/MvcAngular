using NikeCopy.Services;

namespace NikeCopy
{
    public class Startup
    {
        public IConfiguration ConfigRoot { get; }

        public Startup(IConfiguration configuration)
        {
            ConfigRoot = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<INullMailService, NullMailService>();
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddRazorPages();
        }

        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            if (env.IsEnvironment("Development")) {
                app.UseDeveloperExceptionPage();
                //app.UseExceptionHandler("/Error");
                //app.UseHsts();
            }
            else
            {
                app.UseExceptionHandler("/error");
            }
            //app.UseHttpsRedirection();

            // Looks through files to find index.html
            // changes internal path to where that file exists
            //app.UseDefaultFiles(); 

            // That path is then passed to UseStaticFiles()
            // and is able to find static files
            app.UseStaticFiles();

            // Routing allows us to route individual calls that come into the server
            app.UseRouting();
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World");
            //    });
            //});

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllerRoute("Default",
                    "/{controller}/{action}/{id?}",
                    new { controller = "App", action = "Index" 
                });
            });
            //app.UseAuthorization();
            //app.MapRazorPages();
            app.Run();


            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Hello World");
            //});
        }
    }
}
