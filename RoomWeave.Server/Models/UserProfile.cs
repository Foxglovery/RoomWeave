using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace RoomWeave.Server.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public bool IsAdmin { get; set; }
        public string ProfileImage {  get; set; }
        public List<string>? Roles { get; set; }


        [Required]

        public string IdentityUserId { get; set; }


        public IdentityUser IdentityUser { get; set; }
        
    }
}
