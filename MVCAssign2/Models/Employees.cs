using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCAssign2.Models
{
    public class Employees
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [RegularExpression("[a-zA-Z ]+", ErrorMessage = "Only alphabets are allowed")]
        [MinLength(15, ErrorMessage = "Minimum 15 characters required")]
        public string Name { get; set; }

        [DOBValidations]
        public DateTime DateOfBirth { get; set; }

        [DOJValidator]
        public DateTime DateOfJoining { get; set; }

        [Required]
        [Range(12000, 60000, ErrorMessage = "Salary must be between 12000 and 60000")]
        public int? salary { get; set; }

        [DeptValidator]
        [Required]
        public string Dept { get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        [NotMapped]
        [DataType(DataType.Password)]
        public string ReTypePassword { get; set; }
    }
}
