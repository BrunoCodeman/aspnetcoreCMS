using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kaigang.Models.Entities
{
    public class Comment : Model
    {
        [Required]
        [Key]
        public Guid ID { get; set; }
        
        [Required]
        public User Author {get; set;}
        
        [Required]
        public string Text {get; set;}

        public DateTime CreationDate {get; set;}

    }
}