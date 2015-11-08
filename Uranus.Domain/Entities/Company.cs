using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Uranus.Domain.Entities
{
    [Table("Company")]
    public class Company
    {
        public int Id { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [StringLength(200)]
        public string CompanyName { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string CompanyType { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(200)]
        public string CompanyAddress { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string EmaildId { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string ContactNo { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string BusinessHours { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string FacebookLink { get; set; }

         

    }
}