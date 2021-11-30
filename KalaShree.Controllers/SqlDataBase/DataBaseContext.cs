using KalaShree.models.Masters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalaShree.Controllers.SqlDataBase
{
   public class DataBaseContext :DbContext
    {
        public DataBaseContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Article> Articles { get; set; }
    }
}
