using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class BlogPost
    {
        [Key]
        public int BlogId { get; set; }

        [Required]
        [MaxLength(256)]
        public string Title { get; set; } = String.Empty;

        [Required]
        [MaxLength(1024)]
        public string Content { get; set; } = String.Empty;

        [Required]
        public DateTime Created_At { get; set; }

        public DateTime Updated_At { get; set; }

        [Required]
        public string Thumbnail { get; set; } = String.Empty;

    }
}
