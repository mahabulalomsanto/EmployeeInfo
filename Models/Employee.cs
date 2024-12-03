using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeInfo.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required] public required string Name { get; set; }
        [Required] public required string Email { get; set; }
        [Required] public required string Mobile { get; set; }

        [Column(TypeName = "date")]
        [Required] public required DateTime DOB { get; set; }
        public string? PhotoPath { get; set; }

    }
}
