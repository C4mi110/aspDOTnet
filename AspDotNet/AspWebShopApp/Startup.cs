﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspWebShopApp.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AspWebShopApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();

            services.AddTransient<IProductRepository, EFProductRepository>();

            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration["Data:SportStoreProducts:ConnectionString"]));


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseDeveloperExceptionPage(); // informacje szczegółowe o błędach
            app.UseStatusCodePages(); // Wyświetla strony ze statusem błędu
            app.UseStaticFiles(); // obsługa treści statycznych css, images, js
            app.UseRouting();

            app.UseRouting();

            app.UseEndpoints(routes => {

                routes.MapControllerRoute(
                    name: default,
                    pattern: "{controller=Product}/{action=List}/{id?}");

                routes.MapControllerRoute(
                    name: default,
                    pattern: "Product/{category}",
                    defaults: new
                    {
                        controller = "Product",
                        action = "List",
                    });

                routes.MapControllerRoute(
                    name: null,
                    pattern: "Admin/{action=Index}",
                    defaults: new
                    {
                        controller = "Admin",
                    });
                /*
                routes.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Product}/{action=List}/{id?}");

                routes.MapControllerRoute(
                    name: null,
                    pattern: "Product/{category}",
                    defaults: new 
                    {
                        controller = "Product",
                        action = "List",
                    });

                routes.MapControllerRoute(
                    name: "null",
                    pattern: "{controller}/{action}/{?id?}",
                    defaults: new
                    {
                        controller = "Admin",
                        action = "Index",
                    });*/
                routes.MapControllerRoute(name: null, pattern: "{controller}/{action}/{id?}");
            });
            SeedData.EnsurePopulated(app);
        }

        public Startup(IConfiguration configuration) =>
            Configuration = configuration;
        public IConfiguration Configuration { get; }

    }
}
