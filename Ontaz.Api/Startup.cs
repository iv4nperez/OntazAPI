using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Ontaz.Api.Infraestructure;
using Ontaz.Dal.DBOntaz.Context;

namespace Ontaz.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get;  }

        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureServices();
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddDbContext<APIContext>(options => options.UseSqlServer(Configuration.GetConnectionString("defaultConnection")));
            services.AddSwaggerGen();


            services.AddCors(options => {
                options.AddDefaultPolicy(builder => {
                    builder.WithOrigins(Configuration["AllowedHosts"]).AllowAnyMethod().AllowAnyHeader();
                });
            });

        }

        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            
            app.UseCors();

            app.UseEndpoints(endpoints => { 
                endpoints.MapControllers(); 
            });
        }
    }
}
