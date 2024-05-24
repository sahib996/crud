using Microsoft.AspNetCore.Identity;

namespace car.Models
{
    public class AppUser:IdentityUser
    {
        public string Name  { get; set; }
        public string SurnAme { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
