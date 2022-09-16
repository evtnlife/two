using Volo.Abp.Modularity;

namespace TWO;

[DependsOn(
    typeof(TWOApplicationModule),
    typeof(TWODomainTestModule)
    )]
public class TWOApplicationTestModule : AbpModule
{

}
