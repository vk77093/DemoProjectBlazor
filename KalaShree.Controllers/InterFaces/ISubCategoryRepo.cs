using KalaShree.models.Masters;
using System.Collections.Generic;

namespace KalaShree.Controllers.InterFaces
{
    public interface ISubCategoryRepo
    {
        void AddSubCategory(SubCategory subCategory);
        bool AlreadyExistSubCategory(SubCategory subCategory);
        void DeleteSubcategory(int subCateId);
        IEnumerable<SubCategory> GetSubCategories();
        SubCategory GetSubCategoryById(int subCatId);
        void UpdateSubCategory(SubCategory subCategory);
    }
}