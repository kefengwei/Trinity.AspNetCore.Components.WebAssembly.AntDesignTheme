using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.AspNetCore.Components.WebAssembly.Theming.Routing;
using Volo.Abp.AspNetCore.Components.WebAssembly.Theming.Toolbars;
using Volo.Abp.Modularity;
using AntDesign;
using Microsoft.Extensions.DependencyInjection;

namespace Volo.Abp.AspNetCore.Components.WebAssembly.AntDesignTheme
{
    [DependsOn(
        typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
        )]
    public class AbpAspNetCoreComponentsWebAssemblyAntDesignThemeModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAntDesign();
            
            Configure<AbpRouterOptions>(options =>
            {
                options.AdditionalAssemblies.Add(typeof(AbpAspNetCoreComponentsWebAssemblyAntDesignThemeModule).Assembly);
            });

            Configure<AbpToolbarOptions>(options =>
            {
                options.Contributors.Add(new AntDesignThemeToolbarContributor());
            });
        }
    }
}
