using test2.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace test2;

public abstract class test2Controller : AbpControllerBase
{
    protected test2Controller()
    {
        LocalizationResource = typeof(test2Resource);
    }
}
