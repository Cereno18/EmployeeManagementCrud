using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace EmployeeSystemManagement.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Username or Email is required.")]
        [DisplayName("Username or Email")]
        public string UserNameOrEmail { get; set; }


        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
