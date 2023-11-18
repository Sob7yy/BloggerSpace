using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project.Models
{
    public class Catalog
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        public virtual List<Post>? Posts { get; set; }
    }
}
