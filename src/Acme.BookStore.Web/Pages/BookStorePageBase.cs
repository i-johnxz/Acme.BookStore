using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Acme.BookStore.Domain.Shared.Localization;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acme.BookStore.Web.Pages
{
    public abstract class BookStorePageBase : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<BookStoreResource> L { get; set; }
    }
}
