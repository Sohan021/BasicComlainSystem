using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Complain_System.Models.Auth
{
    public class ApplicationRole : IdentityRole
    {
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
