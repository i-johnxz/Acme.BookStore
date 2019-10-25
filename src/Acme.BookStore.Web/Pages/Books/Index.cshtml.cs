using System.Threading.Tasks;
using Acme.BookStore.Application.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Acme.BookStore.Web.Pages.Books
{
    public class IndexModel : BookStorePageModelBase
    {
        [BindProperty]
        public CreateUpdateBookDto Book { get; set; }

        private readonly IBookAppService _bookAppService;

        public IndexModel(IBookAppService bookAppService)
        {
            _bookAppService = bookAppService;
        }


        public async Task<IActionResult> OnPostAsync()
        {

            await _bookAppService.CreateAsync(Book);
            return NoContent();
        }
    }
}