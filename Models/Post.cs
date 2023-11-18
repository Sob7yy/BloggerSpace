using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project.Models
{
    public class Post
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(100)]
        public string? Brief { get; set; }
        public string? Description { get; set; }

        [Column(TypeName = "time(7)")]
        public TimeSpan Time { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }

        [ForeignKey("Catalog")]
        public int CatalogId { get; set; }

        public virtual Author Author { get; set; }

        public virtual Catalog Catalog { get; set; }
    }
}
