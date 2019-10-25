using System;
using System.Collections.Generic;
using System.Text;
using Acme.BookStore.Application.Contracts;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.TenantManagement;

namespace Acme.BookStore.HttpApi
{
    [DependsOn(
        typeof(BookStoreApplicationContractsModule),
        typeof(AbpIdentityHttpApiModule),
        typeof(AbpPermissionManagementHttpApiModule),
        typeof(AbpTenantManagementHttpApiModule),
        typeof(AbpFeatureManagementHttpApiModule)
    )]
    public class BookStoreHttpApiModule : AbpModule
    {

    }
}
