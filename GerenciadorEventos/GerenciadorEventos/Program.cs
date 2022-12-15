using GerenciadorEventos.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorEventos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<Context>
                (options => options.UseSqlServer("Data Source=localhost; Initial Catalog=GerenciadorEventos; Integrated Security=False; User ID=GerenciadorEventos; Password=GerenciadorEventos; Connect Timeout=15; Encrypt=False; Trusted_Connection=True; TrustServerCertificate=True"));
            //("Data Source=localhost; Initial Catalog=GerenciadorEventos;" +
            //"User ID=GerenciadorEventos; Password=GerenciadorEventos; language=Portuguese; Connect Timeout=15;Encrypt=False;" +
            //"Trusted_Connection=True; TrustServerCertificate=True")
            //);
            //"Data Source=localhost; Initial Catalog=GerenciadorEventos; Integrated Security=False; User ID=GerenciadorEventos; Password=GerenciadorEventos; Connect Timeout=15; Encrypt=False; TrustServerCertificate=False"));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}