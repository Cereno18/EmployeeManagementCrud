using System.ComponentModel.DataAnnotations;

namespace EmployeeSystemManagement.Models
{
    public class RegistrationViewModel
    {
        [Required(ErrorMessage = "First name is required.")]
        [MaxLength(16, ErrorMessage = "Max is 16 Characters allowed.")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Last name is required.")]
        [MaxLength(16, ErrorMessage = "Max is 16 Characters allowed.")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Email is required.")]
        //[EmailAddress(ErrorMessage ="Please enter a valid email.")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter a valid email.")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Username is required.")]
        [MaxLength(16, ErrorMessage = "Max is 16 Characters allowed.")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        [StringLength(16, MinimumLength = 8, ErrorMessage = "Max is 16 minimum is 8 Password allowed.")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Please confirm your password.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
