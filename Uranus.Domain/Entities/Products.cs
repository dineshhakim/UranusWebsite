using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Uranus.Domain.Entities
{
    [Table("Products")]
    public class Products
    {
        public int Id { get; set; }

        [Column(TypeName = "VARCHAR")]
        
        [StringLength(100)]
        [DisplayName("Name")]
        public string ProductName { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [StringLength(4000)]
        
        [DisplayName("Description")]
        [AllowHtml]
        public string ProductDescription { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [DisplayName("ImageUrl")]
        public string ImageUrl { get; set; }
    }
}