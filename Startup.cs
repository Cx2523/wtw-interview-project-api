using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using wtw_interview_project_api.Database;
using wtw_interview_project_api.Repositories;
using wtw_interview_project_api.Services;
using wtw_INTerview_project_api.Database;

namespace wtw_interview_project_api
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
            services.AddControllers();
            services.AddSingleton(new DatabaseConfig { Name = Configuration["DatabaseName"] });
            services.AddSingleton<IDatabaseBootstrap, DatabaseBootstrap>();
            services.AddScoped<IAgentService, AgentService>();
            services.AddScoped<IAgentRepository, AgentRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            serviceProvider.GetService<IDatabaseBootstrap>().Setup();
        }
    }
}
