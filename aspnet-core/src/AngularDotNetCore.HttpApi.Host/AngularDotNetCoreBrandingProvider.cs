using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AngularDotNetCore
{
    [Dependency(ReplaceServices = true)]
    public class AngularDotNetCoreBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AngularDotNetCore";
    }
}
