using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Bastion.Core.DomainService;
using Bastion.Infrastructure.SQLData;
using Bastion.Core.ApplicationService;
using Bastion.Core.ApplicationService.Services;
using Bastion.Infrastructure.SQLData.Repositories;

namespace Bastion.UI.RestAPI
{
	public class Startup
	{
		public Startup(IConfiguration configuration, IHostingEnvironment environment)
		{
			Configuration = configuration;
			Environment = environment;
		}

		public IConfiguration Configuration { get; }
		public IHostingEnvironment Environment { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddCors(options =>
			{
				options.AddPolicy("CorsPolicy",
					builder => builder.AllowAnyOrigin()
					.AllowAnyMethod()
					.AllowAnyHeader()
					.AllowCredentials());
			});

			if (Environment.IsDevelopment())
			{
				services.AddDbContext<BastionContext>(opt =>
				{
					opt.UseSqlite("Data Source=bastionApp.db");
				});
			}
			else
			{
				services.AddDbContext<BastionContext>(opt =>
				{
					opt.UseSqlServer(Configuration.GetConnectionString("defaultConnection"));
				});
			}

			services.AddScoped<ISpeakerRepository, SpeakerRepository>();
			services.AddScoped<ISpeakerService, SpeakerService>();

			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
			services.AddMvc().AddJsonOptions(options =>
			{
				options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
			});

			services.AddMvc();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				using (var scope = app.ApplicationServices.CreateScope())
				{
					var ctx = scope.ServiceProvider.GetService<BastionContext>();
					ctx.Database.EnsureDeleted();
					ctx.Database.EnsureCreated();
					DatabaseInitializer.Seed(ctx);
				}
			}
			else
			{
				app.UseHsts();
				using (var scope = app.ApplicationServices.CreateScope())
				{
					var ctx = scope.ServiceProvider.GetService<BastionContext>();
					ctx.Database.EnsureCreated();
				}
			}
			app.UseCors("CorsPolicy");

			app.UseHttpsRedirection();
			app.UseMvc();
		}
	}
}
