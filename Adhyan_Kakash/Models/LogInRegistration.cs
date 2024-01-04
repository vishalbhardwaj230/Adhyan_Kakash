using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Adhyan_Kakash.Models
{
    public partial class LogInRegistration
    {
        [Required(ErrorMessage = "Student Name is required")]
        public string StudentName { get; set; }

        [Required(ErrorMessage = "Father Name is required")]
        public string FatherName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        public string Phone { get; set; }
    }
}
