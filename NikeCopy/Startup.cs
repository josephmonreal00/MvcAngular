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
            services.AddRazorPages();
        }

        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            if (!app.Environment.IsDevelopment()) {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }
            //app.UseHttpsRedirection();

            // Looks through files to find index.html
            // changes internal path to where that file exists
            app.UseDefaultFiles(); 

            // That path is then passed to UseStaticFiles()
            // and is able to find static files
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World");
                });
            });
            app.UseAuthorization();
            app.MapRazorPages();
            app.Run();


            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Hello World");
            //});
        }
    }
}
