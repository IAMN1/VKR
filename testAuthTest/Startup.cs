using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ServerForAppV1.Models;

namespace testAuthTest
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Ѕƒ
            string con = "Server=IAMN1;Database=testappv2;user Id=mobileApp; password=mobileApp;";
            // устанавливаем контекст данных
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(con));
            services.AddControllers(); // используем контроллеры без представлений
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
