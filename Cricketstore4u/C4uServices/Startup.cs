using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C4u.Data;
using C4u.Data.Repositories;
using C4u.Library.Interface;
using C4u.Library.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace C4uServices
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
            services.AddTransient<C4uDbContext>();
            services.AddTransient<IRepository<Customer>, CustomerRepository>();
            services.AddDbContext<C4uDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("C4uAtlatna")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
