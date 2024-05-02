using System.ComponentModel.DataAnnotations;

namespace WebApp1ByGiver.Models
{
    public class Student
    {
        [Required]
        public int StdID { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "Name length should be within 2 and 60")]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Faculty { get; set; }
        public Student() { }
        public Student(int Id, string Name, string Address, string Faculty)
        {
            this.StdID = Id;
            this.Name = Name;
            this.Address = Address;
            this.Faculty = Faculty;

        }
    }
}
