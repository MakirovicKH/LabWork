using Microsoft.EntityFrameworkCore;
using System.Net.NetworkInformation;
using Uniqlo.BL.Services.Abstractions;
using Uniqlo.BL.Services.Concretes;
using Uniqlo.DAL.Contexts;
using Uniqlo.MVC;

namespace Uniqlo.MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<UniqloDbContext>(option=>
            option.UseSqlServer(builder.Configuration.GetConnectionString("MsSql")));

            //BL A AIDDI ASAGI  scop hisse


            builder.Services.AddScoped<ISliderItemService,SliderItemService>();
            ////////////////

            var app = builder.Build();

            app.UseStaticFiles();



            app.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
          );

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");


            app.Run();
        }
    }
}
