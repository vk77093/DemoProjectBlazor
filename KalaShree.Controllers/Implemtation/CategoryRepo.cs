using KalaShree.Common.SequenceClass;
using KalaShree.Controllers.InterFaces;
using KalaShree.Controllers.SqlDataBase;
using KalaShree.models.Masters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalaShree.Controllers.Implemtation
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly DataBaseContext dataBase;

        public CategoryRepo(DataBaseContext dataBase)
        {
            this.dataBase = dataBase;
        }
        public IEnumerable<Category> GetCategories()
        {
            return dataBase.Categories.ToList();
        }
        public void AddCategory(Category category)
        {
            try
            {
                category.CategoryCode = GetCategoryCode(category.CategoryCode);
                dataBase.Categories.Add(category);
                dataBase.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
          

        }
        public Category GetCategoriesById(int categoryId)
        {
            var cateId = dataBase.Categories.Find(categoryId);
            if (cateId != null)
            {
                return cateId;
            }
            else
            {
                return null;
            }
        }
        public void UpdateCategory(Category category)
        {
            var updateCat = dataBase.Categories.Find(category.CategoryId);
            if (updateCat == null) return;
            updateCat.CategoryName = category.CategoryName;
            updateCat.CategoryCode = category.CategoryCode;
            updateCat.UpdatedAt = DateTime.Now;
            dataBase.SaveChanges();
        }
        public void DeleteCategory(int categoryId)
        {
            var DelToCate = dataBase.Categories.Find(categoryId);
            if (DelToCate == null) return;
            dataBase.Categories.Remove(DelToCate);
            dataBase.SaveChanges();
        }
        public bool AlreadyExtistCategory(Category category)
        {
            Category oldCateCodeAndName = dataBase.Categories.FirstOrDefault(
                   m => m.CategoryCode == category.CategoryCode || m.CategoryName == category.CategoryName);
            if (oldCateCodeAndName != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string GetCategoryCode(string codeName)
        {
            IEnumerable<Category> categories = GetCategories();
            if (categories.Count() <= 0)
            {
                codeName = SequenceParameter.CategorySequenec + 1;
            }
            else
            {
                foreach(var cat in categories)
                {
                    int count = 1;
                    codeName = SequenceParameter.CategorySequenec +(cat.CategoryId+count++);
                }
            }
            return codeName;
        }

    }
}
