using KalaShree.models.Masters;
using System.Collections.Generic;

namespace KalaShree.Controllers.InterFaces
{
    public interface ICategoryRepo
    {
        void AddCategory(Category category);
        void DeleteCategory(int categoryId);
        IEnumerable<Category> GetCategories();
        Category GetCategoriesById(int categoryId);
        void UpdateCategory(Category category);
        bool AlreadyExtistCategory(Category category);
    }
}