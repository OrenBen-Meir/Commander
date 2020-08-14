using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Models
{
    public class Command
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("how_to")]
        public string HowTo { get; set; }

        [Required]
        [Column("line")]
        public string Line { get; set; }

        [Required]
        [MaxLength(510)]
        [Column("platform")]
        public string Platform { get; set; }
    }
}
