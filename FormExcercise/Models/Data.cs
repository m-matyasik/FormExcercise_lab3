using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FormExcercise.Models
{
    public class Data
    {
        [Required(ErrorMessage = "Enter name"), MinLength(2)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter surname"), MinLength(2)]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Enter Email"),DataType(DataType.EmailAddress), RegularExpression(".+\\@.+\\.[a-z]{2,3}")] 
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter password."), RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,}$", ErrorMessage = "Password must have at least 8 characters, one digit, one uppercase and one lowercase letter.")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Confirm password doesn't match.")]
        public string ConfirmPassword { get; set; }
        [Phone, RegularExpression("(?<!\\w)(\\(?(\\+|00)?48\\)?)?[ -]?\\d{3}[ -]?\\d{3}[ -]?\\d{3}(?!\\w)", ErrorMessage = "Phone number should have 9 digits in standard format or separated by '-'.")]
        public string Phone { get; set; }
        [Range(10, 80, ErrorMessage = "Yout age must be between 10 and 80.")]
        public int Age { get; set; }
        public string City { get; set; }
        public enum Cities {
            [Display(Name = "Berlin")]
            Berlin,
            [Display(Name = "Warsaw")]
            Warsaw,
            [Display(Name = "Stockholm")]
            Stockholm,
            [Display(Name = "London")]
            London,
            [Display(Name = "Paris")]
            Paris
        }

    }
}
