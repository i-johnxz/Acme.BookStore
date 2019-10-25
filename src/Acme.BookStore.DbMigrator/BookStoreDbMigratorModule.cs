﻿using System;
using System.Collections.Generic;
using System.Text;
using Acme.BookStore.Application.Contracts;
using Acme.BookStore.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.BookStore.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(BookStoreEntityFrameworkCoreDbMigrationsModule),
        typeof(BookStoreApplicationContractsModule)
    )]
    public class BookStoreDbMigratorModule : AbpModule
    {

    }
}
