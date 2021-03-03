using System;
using System.ComponentModel.DataAnnotations;
using DataBound.Models;


namespace DataBound.Models
{
    
    public class AuthorClass
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(50)]
        public String Email { get; set; }

        [DataType(DataType.Url)]
        [StringLength(50)]
        public String WebsiteAddress { get; set; }

        [DataType(DataType.PhoneNumber)]
        [StringLength(12)]
        public String TelephoneNumber { get; set; }

        [StringLength(100)]
        public String Country { get; set; }

        [StringLength(100)]
        public String Province { get; set; }
        [StringLength(10)]
        public String PostalCode { get; set; }

   
        public AuthorClass()
        {
        }
    }
}
