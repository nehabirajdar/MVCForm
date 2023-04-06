using Microsoft.Build.Framework;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace MVCForm.Models
{
    public class Employee
    {
        [Required]
        [Display(Name = "Employee Id")]
        [DataType(DataType.Text)]

        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        [DataType(DataType.Text)]
        [Display(Name="Employee Name")]
        public string Name { get; set; }
        [Required]
        [Range(minimum:18,maximum:50)]

        public int age { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [MaxLength(40)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name="Date Of Joining")]
        public DateTime DOJ { get; set; }
        [Required]
        public double Salary { get; set; }

    }
}
