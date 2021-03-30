using System.ComponentModel.DataAnnotations;

namespace Complain_System.ViewModels
{
    public class CreateRoleViewModel
    {
        public string Id { get; set; }
        [Required]
        [Display(Name = "Role")]
        public string RoleName { get; set; }
    }
}
