using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalaShree.models.Masters
{
  public  class Article
    {
        [Key]
        public int ArticleId { get; set; }
        [ForeignKey("SubCategory")]
        public int SubCategoryId { get; set; }
        [Required]
        public string ArticleCode { get; set; }
        [Required]
        public string ArticleName { get; set; }
        public string ArticleDescription { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }

        public virtual SubCategory SubCategory { get; set; }
    }
}
