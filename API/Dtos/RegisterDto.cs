using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class RegisterDto
    {
        [Required]
        public string DisplayName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        
// password must contain 1 number (0-9)
// password must contain 1 uppercase letters
// password must contain 1 lowercase letters
// password must contain 1 non-alpha numeric number
// password is 8-16 characters with no space
        [Required]
        [RegularExpression(
            // "/^(?=.*\\d)(?=.*[A-Z])(?=.*[a-z])(?=.*[^\\w\\d\\s:])([^\\s]){8,16}$/gm",
            "(?=^.{6,10}$)(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&amp;*()_+}{&quot;:;'?/&gt;.&lt;,])(?!.*\\s).*$",
            ErrorMessage = @"password must contain 1 number (0-9), password must contain 1 uppercase letters, password must contain 1 lowercase letters, password must contain 1 non-alpha numeric number, password is 8-16 characters with no space")]
        public string Password { get; set; }
    }
}