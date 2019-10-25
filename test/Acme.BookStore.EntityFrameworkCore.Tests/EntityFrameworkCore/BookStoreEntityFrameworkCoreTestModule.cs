using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Acme.BookStore.TestBase;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.BookStore.EntityFrameworkCore.Tests.EntityFrameworkCore
{

    [DependsOn(
        typeof(BookStoreEntityFrameworkCoreDbMigrationsModule),
        typeof(BookStoreTestBaseModule)
        )]
    public class BookStoreEntityFrameworkCoreTestModule : AbpModule
    {
        private SqlConnection _sqlConnection;

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            ConfigureSqlServer(context.Services);
        }

        private void ConfigureSqlServer(IServiceCollection services)
        {
            _sqlConnection = CreateDatabaseAndGetConnection();

            services.Configure<AbpDbContextOptions>(options =>
            {
                options.Configure(context => { context.DbContextOptions.UseSqlServer(_sqlConnection); });
            });
        }

        public override void OnApplicationShutdown(ApplicationShutdownContext context)
        {
            _sqlConnection.Dispose();
        }

        private static SqlConnection CreateDatabaseAndGetConnection()
        {
            var connection =
                new SqlConnection(
                    "Server=(localdb)\\projects;Database=BookStore;Integrated Security=true;MultipleActiveResultSets=true");

            connection.Open();

            var options = new DbContextOptionsBuilder<BookStoreMigrationsDbContext>()
                .UseSqlServer(connection)
                .Options;

            using (var context = new BookStoreMigrationsDbContext(options))
            {
                context.GetService<IRelationalDatabaseCreator>().CreateTables();
            }

            return connection;
        }
    }
}
