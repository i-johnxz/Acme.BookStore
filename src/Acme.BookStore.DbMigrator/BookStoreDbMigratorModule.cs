using Acme.BookStore.Application.Contracts;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.BookStore.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(BookStoreApplicationContractsModule)
    )]
    public class BookStoreDbMigratorModule : AbpModule
    {
        
    }
}