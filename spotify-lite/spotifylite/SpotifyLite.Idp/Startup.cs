using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using SpotifyLite.Idp.GrantTypeValidator;
using SpotifyLite.Idp.ProfileService;
using SpotifyLite.Repository;

namespace SpotifyLite.Idp
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
            services.RegisterRepository(Configuration.GetConnectionString("SpotifyDB"));

            services.AddIdentityServer()
                    .AddInMemoryIdentityResources(IdentityServerConfiguration.IdentityServerConfiguration.GetIdentityResources())
                    .AddInMemoryApiScopes(IdentityServerConfiguration.IdentityServerConfiguration.GetApiScopes())
                    .AddInMemoryApiResources(IdentityServerConfiguration.IdentityServerConfiguration.GetApiResources())
                    .AddInMemoryClients(IdentityServerConfiguration.IdentityServerConfiguration.GetClients())
                    .AddResourceOwnerValidator<CustomPasswordValidator>()
                    .AddProfileService<UserProfile>()
                    .AddDeveloperSigningCredential();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SpotifyLite.Idp", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SpotifyLite.Idp v1"));
            }

            app.UseHttpsRedirection();

            app.UseIdentityServer();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
