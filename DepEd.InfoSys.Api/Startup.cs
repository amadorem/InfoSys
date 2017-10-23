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
using Swashbuckle.AspNetCore.Swagger;
using DepEd.InfoSys.Data.Interfaces;
using DepEd.InfoSys.Data.Repositories;
using DepEd.InfoSys.Service.Interfaces;
using DepEd.InfoSys.Service.Services;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;
using DepEd.InfoSys.Data;

namespace DepEd.InfoSys.Api
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
            services.AddMvc();

            services.AddDbContext<InfoSysDbContext>(options => options
                .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=InfoSysDbContext;Trusted_Connection=True;"));

           
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IRegionService, RegionService>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "DepEd Information System", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            AutoMapper.Configuration.Configure();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "DepEd Information System V1");
            });



            app.UseMvc();
        }
    }
}
