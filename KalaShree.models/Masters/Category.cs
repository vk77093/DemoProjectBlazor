using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalaShree.models.Masters
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
       
        public string CategoryCode { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public string CategoryDesc { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }
    }
}
