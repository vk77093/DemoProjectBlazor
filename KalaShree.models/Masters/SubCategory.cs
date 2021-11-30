using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalaShree.models.Masters
{
   public class SubCategory
    {
        [Key]
        public int SubCategoryId { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        [Required]
        public string SubCategoryCode { get; set; }
        [Required]
        public string SubCategoryName { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }
        public virtual Category Category { get; set; }
    }
}
