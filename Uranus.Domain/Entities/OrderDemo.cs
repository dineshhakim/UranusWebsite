using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Uranus.Domain.Entities
{
    [Table("OrderDemo")]
    public class OrderDemo
    {
        public int Id { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        [Required]
        public string Designation { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        [Required]
        public string OrganizationName { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string OrganizationType { get; set; }
        [Column(TypeName = "int")]

        [Required]
        public int NoOfBranch { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Required]
        public string ContactNo { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Required(ErrorMessage = "Email is required")]
        public string EmailId { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(200)]
        [Required]
        public string Address { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(300)]

        public string Comments { get; set; }
    }
}