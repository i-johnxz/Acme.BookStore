using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Acme.BookStore.Domain.Shared.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acme.BookStore.Web.Pages
{
    public abstract class BookStorePageModelBase : AbpPageModel
    {
        protected BookStorePageModelBase()
        {
            LocalizationResourceType = typeof(BookStoreResource);
        }
    }
}
