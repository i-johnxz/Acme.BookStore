using System;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Users;

namespace Acme.BookStore.Domain.Users
{
    public class AppUser : FullAuditedAggregateRoot<Guid>, IUser
    {
        public virtual Guid? TenantId { get; private set; }
        public virtual string UserName { get; private set; }
        public virtual string Email { get; private set; }
        public virtual string Name { get; private set; }
        public virtual string Surname { get; private set; }
        public virtual bool EmailConfirmed { get; private set; }
        public virtual string PhoneNumber { get; private set; }
        public virtual bool PhoneNumberConfirmed { get; private set; }

        private AppUser()
        {
            
        }
    }
}