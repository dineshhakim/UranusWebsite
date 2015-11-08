
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Uranus.Domain.Entities
{
    [Table("ContactUs")]
    public class ContactUs
    {
        public int Id { get; set; }


        [Column(TypeName = "VARCHAR")]
        [StringLength(150)]
        public string Name { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(200)]
        public string Address { get; set; }

        [DisplayName("Email")]
        [StringLength(50)]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Required(ErrorMessage = "Email is required")]
        [Column(TypeName = "VARCHAR")]

        public string EmailId { get; set; }

        [Required(ErrorMessage = "PhoneNo is required")]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string PhoneNo { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [StringLength(300)]
        public string Message { get; set; }

        public string ShortMessage
        {
            get
            {

                if (Message != null && Message.Length > 50)
                {
                    return Message.Substring(0, 50);
                }
                return Message;

            }
        }
    }
}
