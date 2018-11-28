using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trail.Data
{
    public class Note
    {
        [Key]
        public int NoteId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        public string Content { get; set; }
        [Display(Name = "Note was Created")]
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
