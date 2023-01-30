using Autofac;
using Autofac.Extensions.DependencyInjection;
using SqlSugar;


namespace RCWebApplication.CfgFile
{
    public static class HostBuildExtend
    {
        public static void Register(this WebApplicationBuilder app)
        {
            app.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
            app.Host.ConfigureContainer<ContainerBuilder>(builder =>
            {
                builder.RegisterModule(new AutofactModuleRegister());
                app.Services.AddAutoMapper(typeof(AutoMapperConfigs));
            });
        }
    }
}
