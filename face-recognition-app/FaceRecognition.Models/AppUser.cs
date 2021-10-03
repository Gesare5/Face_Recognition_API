using Microsoft.AspNetCore.Identity;

namespace FaceRecognition.Models
{
    public class AppUser : IdentityUser
    {
        public string SchoolName { get; set; }
        public string Location { get; set; }
        public string Country { get; set; }

    }
}