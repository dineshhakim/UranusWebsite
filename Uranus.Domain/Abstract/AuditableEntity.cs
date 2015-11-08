using System;
using System.ComponentModel.DataAnnotations;

namespace Uranus.Domain.Abstract
{
    public class AuditableEntity<T> : Entity<T>
    {
        [ScaffoldColumn(false)]
        public DateTime CreatedDate { get; set; }
         
        [ScaffoldColumn(false)]
        public int CreatedBy { get; set; }

         
        
    }
}