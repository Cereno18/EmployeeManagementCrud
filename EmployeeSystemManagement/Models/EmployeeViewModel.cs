using System.ComponentModel.DataAnnotations;

namespace EmployeeSystemManagement.Models
{
    public class EmployeeViewModel
    {
        [Required(ErrorMessage = "Employee number is Required.")]
        public string EmpNo { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Middle name is required.")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        public int PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter a valid email.")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Country is required.")]
        public string Country { get; set; }
        public DateTime DateofBirth { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Department is required.")]
        public string Department { get; set; }

        [Required(ErrorMessage = "Designation is required.")]
        public string Designation { get; set; }
    }
}
