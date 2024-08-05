using Inva.LawMax.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Inva.LawMax.Controllers;


public abstract class LawMaxController : AbpControllerBase
{
    protected LawMaxController()
    {
        LocalizationResource = typeof(LawMaxResource);
    }
}
