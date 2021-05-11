using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MuhtarlikOtomasyonu.Data.DataContext;
using MuhtarlikOtomasyonu.UI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MuhtarlikOtomasyonu.Common.Mappings;
using MuhtarlikOtomasyonu.Data.Contracts;
using MuhtarlikOtomasyonu.Data.Implementation;

namespace MuhtarlikOtomasyonu.UI
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
            /*services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();*/
            
            /*
             * services.AddRazorPages() --> services.AddRazorPages().AddRazorRuntimeCompilation()
             *
             * Runtime'da kod de�i�ikli�i yapabilmek i�in
             *
             * Nuget'ten Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation indirildi.
             */
            services.AddDbContext<MuhtarlikOtomasyonuContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("IdentityConnectionString")));
            services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddAutoMapper(typeof(Maps));
            services.AddScoped<IAdresRepository, AdresRepository>();

            services.AddScoped<IAdresRepository, AdresRepository>();
            services.AddScoped<IAdresteOturanKisiRepository, AdresteOturanKisiRepository>();
            services.AddScoped<IBelgeTalepRepository, BelgeTalepRepository>();
            services.AddScoped<IBelgeTipRepository, BelgeTipRepository>();
            services.AddScoped<IBinaRepository, BinaRepository>();
            services.AddScoped<ICaddeRepository, CaddeRepository>();
            services.AddScoped<IMahalleRepository, MahalleRepository>();
            services.AddScoped<IMuhtarlikRepository, MuhtarlikRepository>();
            services.AddScoped<ISokakRepository, SokakRepository>();
            


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}