using System.Threading.Tasks;

namespace Acme.BookStore.Domain.Data
{
    public interface IBookStoreDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}