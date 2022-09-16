using TWO.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace TWO;

[DependsOn(
    typeof(TWOEntityFrameworkCoreTestModule)
    )]
public class TWODomainTestModule : AbpModule
{

}
