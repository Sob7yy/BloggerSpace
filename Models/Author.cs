using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project.Models
{
    public class Author
    {
        public int Id { get; set; }

        [MaxLength(100), Required]
        public string UserName { get; set; }

        [MinLength(6), MaxLength(20), Required]
        public string Password { get; set; }

        [NotMapped]
        public string ConfirmPasswrod { get; set; }

        [Required]
        public string Email { get; set; }
        public int? Age { get; set; }
        public virtual List<Post> Posts { get; set; }
    }
}
