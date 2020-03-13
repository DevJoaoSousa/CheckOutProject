using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure;
using Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Infrastructure.Factory;
using Infrastructure.Repository;
using BankService;
using BankService.Factory;

namespace API_PaymentGateway
{
    public class Startup
    {
        const string CorsAllowAllOrigins = "AllOrigins";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {   
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo 
                { 
                    Title = "My API", 
                    Version = "v1" 
                });
            });

            services
                .AddCors(options =>
                {
                    options.AddPolicy(CorsAllowAllOrigins,
                    builder => builder.WithOrigins("*").WithHeaders("*").WithMethods("*").WithExposedHeaders("*"));
                });

            //Factories
            services.AddScoped<IConnectionFactory, ConnectionFactory>();
            services.AddScoped<IResponseFactory, ResponseFactory>();

            //Services
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IValidationService, ValidationService>();
            services.AddScoped<IBankService, BankServiceMock>();

            //Repositories
            services.AddScoped<IRepository, Repository>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors(CorsAllowAllOrigins);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
