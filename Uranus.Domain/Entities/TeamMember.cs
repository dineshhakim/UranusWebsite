using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Uranus.Domain.Entities
{
    [Table("TeamMember")]
    public class TeamMember
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        [Column(TypeName = "VARCHAR")]
        public string Name { get; set; }


        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Designation { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR")]
        [StringLength(300)]
        public string About { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string SocialLink { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string EmailId { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string ImageUrl { get; set; }


        public bool Active { get; set; }
        public int Order { get; set; }
    }
}