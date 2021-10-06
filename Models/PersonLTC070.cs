using System;
using System.ComponentModel.DataAnnotations;

namespace LeThiChang070.Models
{
    public class Movie
    {
        [Key]
        [MaxLength(20)]
        public int PersonId { get; set; }
        [StringLength(50)]
        public string PersonName { get; set; }
        

    
    }
}