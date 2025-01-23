using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EmployeeSystemManagement.Models.Entities
{
    [Index(nameof(Email), IsUnique = true)]
    [Index(nameof(UserName), IsUnique = true)]
    public class UserAccount
    {
          
           
            public int Id { get; set; }

            [Required(ErrorMessage = "First name is required.")]
            [MaxLength(16, ErrorMessage = "Max is 16 Characters allowed.")]
            public string FirstName { get; set; }


            [Required(ErrorMessage = "Last name is required.")]
            [MaxLength(16, ErrorMessage = "Max is 16 Characters allowed.")]
            public string LastName { get; set; }


            [Required(ErrorMessage = "Email is required.")]
            public string Email { get; set; }


            [Required(ErrorMessage = "Username is required.")]
            [MaxLength(16, ErrorMessage = "Max is 16 Characters allowed.")]
            public string UserName { get; set; }


            [Required(ErrorMessage = "Password is required.")]
            [DataType(DataType.Password)]
            [MaxLength(16, ErrorMessage = "Max is 16 Password allowed.")]
            public string Password { get; set; }
        
    }
}
