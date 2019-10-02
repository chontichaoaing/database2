using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace database2.Data
{
    internal class UserManage<T>
    {
        internal Task FindByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        internal Task CreateAsync(IdentityUser adminUser, string v)
        {
            throw new NotImplementedException();
        }

        internal Task IsInRoleAsync(object currentUser, string v)
        {
            throw new NotImplementedException();
        }
    }
}