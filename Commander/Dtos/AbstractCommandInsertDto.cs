using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Dtos
{
    public abstract class AbstractCommandInsertDto
    {
        [Required]
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; }

        [Required]
        [MaxLength(510)]
        public string Platform { get; set; }
    }
}
