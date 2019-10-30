using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDtos
    {
        [Required]
        [StringLength(32,MinimumLength=4,ErrorMessage="Your username must be at least 4 characters long")]
        public string Username { get; set; }

        [Required]
        [StringLength(16,MinimumLength=5,ErrorMessage="Your bassword shoul contain between 5 and 16 characters")]
        public string Password { get; set; }
    }
}