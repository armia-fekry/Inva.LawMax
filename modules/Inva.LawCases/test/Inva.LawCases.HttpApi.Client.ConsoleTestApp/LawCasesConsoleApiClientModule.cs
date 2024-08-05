using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Inva.LawCases;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(LawCasesHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class LawCasesConsoleApiClientModule : AbpModule
{

}
