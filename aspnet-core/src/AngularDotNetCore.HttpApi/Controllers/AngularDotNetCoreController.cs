using AngularDotNetCore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AngularDotNetCore.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AngularDotNetCoreController : AbpController
    {
        protected AngularDotNetCoreController()
        {
            LocalizationResource = typeof(AngularDotNetCoreResource);
        }
    }
}