using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Uranus.Domain.Entities
{
    [Table("Customers")]
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }


        [Column(TypeName = "VARCHAR")]
        [StringLength(200)]
        public string Address { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string EmailId { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string ContactNo { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string ImageUrl { get; set; }

        [Column(TypeName = "int")]
        public int Order { get; set; }

        [Column(TypeName = "NVARCHAR")]
        [StringLength(300)]
        public string About { get; set; }
    }
}