using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _07_Web_API.Models
{
    public class College
    {
        [Key]
        [Required]
        // Here, "product_id" is the name of column which will be set in the databse
        [Column("college_id", Order = 0)]
        public int Id { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 2)]
        public string Name { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 2)]
        public string Address { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 2)]
        public string Phone { get; set; }
    }
}
