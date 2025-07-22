using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace test2.Blazor.Menus;

public class test2MenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(test2Menus.Prefix, displayName: "test2", "/test2", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
