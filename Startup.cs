using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using WebAppAssignmentDATABASE_5.Models;
using Microsoft.EntityFrameworkCore;
using WebAppAssignmentDATABASE_5.Models.Repo;
using WebAppAssignmentDATABASE_5.Models.Service;
using WebAppAssignmentDATABASE_5.Data;

namespace WebAppAssignmentDATABASE_5
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

       
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IPeopleRepo, DatabasePeopleRepo>();
            services.AddScoped<IPeopleService, PeopleService>();
            services.AddScoped<ICityRepo, CityRepo>();
            services.AddScoped<ICityService, CityService>();
            services.AddScoped<ICountryRepo, CountryRepo>();
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<ILanguageRepo, LanguageRepo>();
            services.AddScoped<ILanguageService, LanguageService>();
            services.AddDbContext<PeopleDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("PersonDB")));

            services.AddMvc();
        }

        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
               
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
