using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models.Comments
{
    public class Comment
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Message { get; set; }
        public DateTime Created { get; set; }
    }
}
