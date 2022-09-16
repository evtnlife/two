using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace TWO;

[Dependency(ReplaceServices = true)]
public class TWOBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "TWO";
}
