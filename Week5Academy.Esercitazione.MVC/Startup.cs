using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week5Academy.Esercitazione.Core.BusinessLayer;
using Week5Academy.Esercitazione.Core.Interfaces;
using Week5Academy.Esercitazione.EF.Repositories;
using Week5Academy.Esercitazione.Mock;
using Week5Academy.Esercitazione.Mock.Repositories;

namespace Week5Academy.Esercitazione.MVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IBusinessLayer, MainBL>();  //DI con BL
            //MOCK x test
            //services.AddScoped<IDishRepository, MockDishRepository>();
            //services.AddScoped<IAccountRepository, MockAccountRepository>();
            //poi la devo fare con EF!
            services.AddScoped<IDishRepository, EFDishRepository>();
            services.AddScoped<IAccountRepository, EFAccountRepository>();
            
            //e devo aggiungere il context : services.addcontext....


            //Autorization   1
            services.AddAuthorization(options =>
            {
                options.AddPolicy("AccountOwner", policy => policy.RequireRole("Owner"));  
                options.AddPolicy("AccountClient", policy => policy.RequireRole("Client"));  

            });
            //autentication   2
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = new PathString("/Account/Login");
                    options.AccessDeniedPath = new PathString("/Account/Forbidden");
                });


            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();   //1
            app.UseAuthorization();    //2

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
