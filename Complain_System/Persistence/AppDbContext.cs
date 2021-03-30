using Complain_System.Models.Auth;
using Complain_System.Models.Regular;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Complain_System.Persistence
{
    public class AppDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }




        public virtual DbSet<Complain> Complains { get; set; }

        public virtual DbSet<ComplainCategory> ComplainCategories { get; set; }

    }
}
