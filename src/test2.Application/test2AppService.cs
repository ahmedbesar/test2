using test2.Localization;
using Volo.Abp.Application.Services;

namespace test2;

public abstract class test2AppService : ApplicationService
{
    protected test2AppService()
    {
        LocalizationResource = typeof(test2Resource);
        ObjectMapperContext = typeof(test2ApplicationModule);
    }
}
