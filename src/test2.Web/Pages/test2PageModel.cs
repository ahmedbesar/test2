using test2.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace test2.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class test2PageModel : AbpPageModel
{
    protected test2PageModel()
    {
        LocalizationResourceType = typeof(test2Resource);
        ObjectMapperContext = typeof(test2WebModule);
    }
}
