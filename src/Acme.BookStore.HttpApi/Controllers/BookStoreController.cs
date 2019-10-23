using Acme.BookStore.Domain.Shared.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.BookStore.HttpApi.Controllers
{
    public abstract class BookStoreController : AbpController
    {
        protected BookStoreController()
        {
            LocalizationResource = typeof(BookStoreResource);
        }
    }
}