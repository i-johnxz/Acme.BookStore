using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Acme.BookStore.Web.Tests
{
    public class BookStoreWebTestStartup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<BookStoreWebTestModule>();
        }


        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}
