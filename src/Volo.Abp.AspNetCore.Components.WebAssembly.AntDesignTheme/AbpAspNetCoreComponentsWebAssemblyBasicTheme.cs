using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.AspNetCore.Components.WebAssembly.Theming.Routing;
using Volo.Abp.AspNetCore.Components.WebAssembly.Theming.Toolbars;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Trinity.AspNetCore.Components.WebAssembly.AntDesignTheme
{
    [DependsOn(
        typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
        )]
    public class TrinityAspNetCoreComponentsWebAssemblyAntDesignThemeModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAntDesign();
            
            Configure<AbpRouterOptions>(options =>
            {
                options.AdditionalAssemblies.Add(typeof(TrinityAspNetCoreComponentsWebAssemblyAntDesignThemeModule).Assembly);
            });

            Configure<AbpToolbarOptions>(options =>
            {
                options.Contributors.Add(new TrinityAntDesignThemeToolbarContributor());
            });
        }
    }
}
