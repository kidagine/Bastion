using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Bastion.Core.DomainService;
using Bastion.Infrastructure.SQLData;
using Bastion.Core.ApplicationService;
using Bastion.Core.ApplicationService.Services;
using Bastion.Infrastructure.SQLData.Repositories;


namespace Bastion.UI.RestAPI
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
			services.AddCors();
			services.AddControllers();
            services.AddDbContext<BastionContext>(opt => opt.UseSqlite("Data Source=bastionApp.db"));
            services.AddScoped<ISpeakerRepository, SpeakerRepository>();
            services.AddScoped<ISpeakerService, SpeakerService>();

			services.AddMvc().AddJsonOptions(options => {
				options.JsonSerializerOptions.MaxDepth = 3;
			});

			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
			app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod());
			if (env.IsDevelopment())
            {
                using (var scope = app.ApplicationServices.CreateScope())
                {
                    BastionContext context = scope.ServiceProvider.GetService<BastionContext>();
                    DatabaseInitializer.Seed(context);
                }
                app.UseDeveloperExceptionPage();
            }
            else
            {
                using (var scope = app.ApplicationServices.CreateScope())
                {
                    BastionContext context = scope.ServiceProvider.GetService<BastionContext>();
                    DatabaseInitializer.Seed(context);
                }
                app.UseDeveloperExceptionPage();
                app.UseHsts();
			}

			app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
