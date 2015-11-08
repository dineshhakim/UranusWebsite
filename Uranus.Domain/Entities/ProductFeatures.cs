using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uranus.Domain.Entities
{
    [Table("ProductFeatures")]
    public class ProductFeatures
    {
        public int Id { get; set; }
        public string Features { get; set; }

        public virtual Products Product { get; set; }
    }
}
