using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Acme.BookStore.Web.Tests.Pages
{
    public class Index_Tests : BookStoreWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/Books");
            response.ShouldNotBeNull();
        }
    }
}
