using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WebTitle.Api.Models;
using WebTitle.Api.Services;



namespace WebTitle.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        readonly string AllowSpecificationOriginsPolicy = "_allowSpecificationOriginsPolicy";

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // requires using Microsoft.Extensions.Options
            services.Configure<MediaTitlesDatabaseSettings>(
                Configuration.GetSection(nameof(MediaTitlesDatabaseSettings)));

            services.AddSingleton<IMediaTitlesDatabaseSettings>(sp =>
                sp.GetRequiredService<IOptions<MediaTitlesDatabaseSettings>>().Value);

            services.AddSingleton<MediaTitleService>();

            //AllowedHosts
            services.AddCors(options =>
            {
                options.AddPolicy(AllowSpecificationOriginsPolicy,
                builder =>
                {
                    builder.WithOrigins("http://localhost:3000"
                                        )
                    .AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else{
                app.UseHsts();
            }

            app.UseCors(AllowSpecificationOriginsPolicy);
            app.UseCors();
            app.UseHttpsRedirection();
            app.UseMvc();

            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute("default", "{controller=MediaTitle}/{action=Get}/{id?}");
            //});
        }
    }
}
