using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
       
        [Required]
        [StringLength(8, MinimumLength = 5, ErrorMessage="You must especify password between 4 and 8")]
        public string Password { get; set; }

    }
}