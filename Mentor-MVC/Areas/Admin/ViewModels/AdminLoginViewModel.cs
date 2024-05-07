using System.ComponentModel.DataAnnotations;

namespace Mentor_MVC.Areas.Admin.ViewModels
{
    public class AdminLoginViewModel
    {
        [Required]
        [MinLength(3)]
        [MaxLength(35)]
        public string UserName { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(355)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
