using CarRental.Database;
using CarRental.API.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using CarRental.Services;
using CarRental.Services.Interface;
using MediatR;
using System.Reflection;
using CarRental.Application.Core.AutoMapper;
using System.Linq;

namespace CarRental.API2
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
            services.AddControllers(options =>
            {
                // Every controller of the app needs authorization
                var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
                options.Filters.Add(new AuthorizeFilter(policy));
            });

            services.AddCors(opt =>
            {
                opt.AddPolicy("CorsPolicy", policy =>
                {
                    policy.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
                });
            });

            // AutoMapper config
            var automapperProfiles = Assembly.GetEntryAssembly()
                                             .GetReferencedAssemblies()
                                             .Select(Assembly.Load)
                                             .SelectMany(x => x.GetTypes())
                                             .Where(x => x.Name.EndsWith("Profile") && x.FullName.StartsWith("CarRental.Application.Core.AutoMapper"))
                                             .ToList();
            automapperProfiles.Add(typeof(MapperProfiles));
            services.AddAutoMapper(automapperProfiles.ToArray());

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CarRental.API2", Version = "v1" });
            });

            // Database Connection
            services.AddDbContext<CarRentalContext>(options =>
                options.UseNpgsql(Configuration.GetConnectionString("HerokuPostgresqlConnection")));

            services.AddIdentityServices(Configuration);

            services.AddMediatR(typeof(Application.Vehicle.List).Assembly);

            services.AddScoped<IVehicleService, VehicleService>();
            services.AddScoped<IRentService, RentService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CarRental.API2 v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseCors(opt =>
            {
                opt.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
