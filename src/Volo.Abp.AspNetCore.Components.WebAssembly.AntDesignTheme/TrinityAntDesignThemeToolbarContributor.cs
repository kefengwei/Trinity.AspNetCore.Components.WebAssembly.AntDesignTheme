using System.Threading.Tasks;
using Trinity.AspNetCore.Components.WebAssembly.AntDesignTheme.Themes.Basic;
using Volo.Abp.AspNetCore.Components.WebAssembly.Theming.Toolbars;

namespace Trinity.AspNetCore.Components.WebAssembly.AntDesignTheme
{
    public class TrinityAntDesignThemeToolbarContributor : IToolbarContributor
    {
        public Task ConfigureToolbarAsync(IToolbarConfigurationContext context)
        {
            if (context.Toolbar.Name == StandardToolbars.Main)
            {
                context.Toolbar.Items.Add(new ToolbarItem(typeof(LanguageSwitch)));
                context.Toolbar.Items.Add(new ToolbarItem(typeof(LoginDisplay)));
            }

            return Task.CompletedTask;
        }
    }
}
