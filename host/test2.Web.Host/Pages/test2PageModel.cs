using test2.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace test2.Pages;

public abstract class test2PageModel : AbpPageModel
{
    protected test2PageModel()
    {
        LocalizationResourceType = typeof(test2Resource);
    }
}
