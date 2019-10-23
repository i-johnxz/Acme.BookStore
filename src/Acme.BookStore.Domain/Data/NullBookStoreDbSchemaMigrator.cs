using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.BookStore.Domain.Data
{
    public class NullBookStoreDbSchemaMigrator : IBookStoreDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}