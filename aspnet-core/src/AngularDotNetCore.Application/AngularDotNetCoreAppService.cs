using System;
using System.Collections.Generic;
using System.Text;
using AngularDotNetCore.Localization;
using Volo.Abp.Application.Services;

namespace AngularDotNetCore
{
    /* Inherit your application services from this class.
     */
    public abstract class AngularDotNetCoreAppService : ApplicationService
    {
        protected AngularDotNetCoreAppService()
        {
            LocalizationResource = typeof(AngularDotNetCoreResource);
        }
    }
}
