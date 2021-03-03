using System;
using System.ComponentModel.DataAnnotations;
namespace DataBound.Models
{
    public class BlogClass
    {
        public BlogClass()
        {
        }
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(100)]
        public string Content { get; set; }

        [Required]
        [StringLength(100)]
        public AuthorClass Author { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }

    
}
}
