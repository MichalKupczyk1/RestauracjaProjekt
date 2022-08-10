using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProjektTaiib.Interfaces;
using ProjektTaiib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ProjektTaiib.Mapper;

namespace ProjektTaiib
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
            services.AddDbContext<Restauracja>();

           
            Restauracja r = new Restauracja();
            services.AddTransient<UnitOfWork>(_ => new UnitOfWork(r));
            UnitOfWork uow = new UnitOfWork(r);

      
            //services.AddDbContext<Restauracja>();
            services.AddTransient<BLZamowienie>(_ => new BLZamowienie(uow));
            services.AddTransient<BLKelner>(_ => new BLKelner(uow));
            services.AddTransient<BLKartaDan>(_ => new BLKartaDan(uow));
            services.AddTransient<BLStolik>(_ => new BLStolik(uow));
            services.AddTransient<BLTypDania>(_ => new BLTypDania(uow));

            services.AddControllersWithViews();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            /* 
   
             przez problemy konstruktora, konstruktor blZamowienie szuka UOW, dostaje restauracje i szaleje dla tego dodaje przez konstruktor i lambde
             */


            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            //services.AddScoped<IZamowienie, BLZamowienie>();
            //services.AddTransient<Zamowienie>();

            // services.AddScoped<IZamowienie, BLZamowienie>();


            //services.AddTransient<Zamowienie>(new Zamowienie());


            /* 
             *   tworze mappera do servicu 
             */
            //services.AddScoped<IKartaDan, BLKartaDan>();
            // services.AddScoped<IKelner, BLKelner>();
            //services.AddScoped<IStolik, BLStolik>();
            // services.AddScoped<ITypDania, BLTypDania>();


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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
