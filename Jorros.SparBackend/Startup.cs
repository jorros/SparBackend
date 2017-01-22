using AutoMapper;
using GraphQL;
using GraphQL.Http;
using Jorros.SparBackend.Queries;
using Jorros.SparBackend.Services;
using Jorros.SparBackend.Services.Base;
using Jorros.SparBackend.Store;
using Jorros.SparBackend.Store.Static;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Jorros.SparBackend
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            if (env.IsEnvironment("Development"))
            {
            }

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

	        services.AddTransient<IProductGateway, StaticProductGateway>();
	        services.AddTransient<IProductService, GatewayProductService>();

	        services.AddTransient<RootSchema>();

			services.AddScoped(sp => SetupMapper());

	        services.AddScoped<IDocumentExecuter, DocumentExecuter>();
	        services.AddScoped<IDocumentWriter, DocumentWriter>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc();
        }

	    private IMapper SetupMapper()
	    {
		    var config = new MapperConfiguration(cfg =>
		    {
			    cfg.AddProfiles(new []
			    {
				    "Jorros.SparBackend.Services"
			    });
		    });

		    return config.CreateMapper();
	    }
    }
}
