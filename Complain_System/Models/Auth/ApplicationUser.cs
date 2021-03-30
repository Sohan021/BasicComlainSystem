using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Complain_System.Models.Auth
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Image { get; set; }

        public string ContactNo { get; set; }

        public virtual ApplicationRole Role { get; set; }

        public ICollection<ApplicationUserRole> UserRoles { get; set; }

    }
}
