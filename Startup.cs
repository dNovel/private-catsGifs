using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Swagger;
using catGifs.Services;
using catGifs.Models;
using System.Net.Http;

namespace catGifs
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment hostingEnvironment)
        {
            Configuration = configuration;
            HostingEnvironment = hostingEnvironment;
        }

        public IConfiguration Configuration { get; }

        public IHostingEnvironment HostingEnvironment { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<HttpClient, HttpClient>();
            services.AddTransient<IImgService, GiphyService>();

            // Configure swagger
            services.AddSwaggerGen(gen =>
            {
                gen.SwaggerDoc("v0.1", new Info { Title = this.Configuration.GetSection("appSettings")["apiName"], Version = "v0.1" });
            });

            services.AddApiVersioning();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                // Use swagger
                app.UseSwagger();
                app.UseSwaggerUI(ui =>
                {
                    ui.SwaggerEndpoint("/swagger/v0.1/swagger.json", "The api v0.1");
                });
            }

            app.UseMvc();
        }
    }
}
