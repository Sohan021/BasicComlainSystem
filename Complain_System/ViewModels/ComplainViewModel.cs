using Complain_System.Models.Auth;
using Complain_System.Models.Regular;

namespace Complain_System.ViewModels
{
    public class ComplainViewModel
    {
        public string Area { get; set; }

        public string Details { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string ContactNo { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public int ComplainCategoryId { get; set; }

        public virtual ComplainCategory ComplainCategory { get; set; }
    }
}
