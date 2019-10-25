using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Shouldly;
using Volo.Abp.Identity;
using Xunit;

namespace Acme.BookStore.Domain.Tests.Samples
{
    public class SampleDomainTests : BookStoreDomainTestBase
    {
        private readonly IIdentityUserRepository _identityUserRepository;
        private readonly IdentityUserManager _identityUserManager;

        public SampleDomainTests(IIdentityUserRepository identityUserRepository, IdentityUserManager identityUserManager)
        {
            _identityUserRepository = identityUserRepository;
            _identityUserManager = identityUserManager;
        }

        [Fact]
        public async Task Should_Set_Email_Of_A_User()
        {
            IdentityUser adminUser;

            await WithUnitOfWorkAsync(async () =>
                {
                    adminUser = await _identityUserRepository.FindByNormalizedUserNameAsync("ADMIN");

                    await _identityUserManager.SetEmailAsync(adminUser, "newemail@abp.io");

                    await _identityUserManager.UpdateAsync(adminUser);
                });

            adminUser = await _identityUserRepository.FindByNormalizedUserNameAsync("ADMIN");

            adminUser.Email.ShouldBe("newemail@abp.io");
        }
    }
}
