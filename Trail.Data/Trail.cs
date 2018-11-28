using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trail.Data
{
    class Trail
    {
        [Key]
        public int TrailID { get; set; }
        public string TrailName { get; set; }
        [Required]
        [Range(1, 5, ErrorMessage = "please choose a number between 1 and 5")]
        public int TrailRank { get; set; }
        [Required]
        public string State { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
   
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
