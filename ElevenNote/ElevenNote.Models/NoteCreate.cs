using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class NoteCreate
    {
        [Required]
        [MinLength(2,ErrorMessage = "Please enter more than 2 characters for the title")]
        [MaxLength(100, ErrorMessage = "Slow down there, Geez! Enter less than 100 characters for the title")]
        public string Title { get; set; }

        [MaxLength(8000)]
        public string Content { get; set; }
    }
}
