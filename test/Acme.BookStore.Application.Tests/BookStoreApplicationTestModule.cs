using System;
using System.Collections.Generic;
using System.Text;
using Acme.BookStore.Domain.Tests;
using Volo.Abp.Modularity;

namespace Acme.BookStore.Application.Tests
{
    [DependsOn(
        typeof(BookStoreApplicationModule),
        typeof(BookStoreDomainTestModule)
    )]
    public class BookStoreApplicationTestModule : AbpModule
    {
    }
}
