using Microsoft.AspNetCore.Identity;

namespace Mentor_MVC.Models
{
    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }    
    }
}
