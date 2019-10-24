using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Acme.BookStore.Web
{
    [Dependency(ReplaceServices = true)]
    public class BookStoreBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "BookStore";
    }
}
