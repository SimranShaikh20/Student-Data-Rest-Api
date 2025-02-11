using System.ComponentModel.DataAnnotations;
namespace StudentProject.Models
{
    public class Student

    {
        public int Id { get; set; }

        [Display(Name = "Student ID")]
        public required string Name { get; set; } // ✅ Requires a value upon object creation

        public string Email { get; set; } = string.Empty; // ✅ Default value
        public long ContactNo { get; set; }
        public string Course { get; set; } = string.Empty;
        public int PursuingYear { get; set; }
        public double CGPA { get; set; }

    }
}
