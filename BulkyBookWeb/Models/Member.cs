using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BulkyBookWeb.Models
{
    public class Member
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        [Column(TypeName = "varchar(35)")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        [Column(TypeName = "varchar(99)")]
        public string Address { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        [Column(TypeName = "varchar(12)")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telephone Number")]
        [MaxLength(11, ErrorMessage = "Maximum 11 charecter only.")]
        public string Tel { get; set; }    
    }
}
