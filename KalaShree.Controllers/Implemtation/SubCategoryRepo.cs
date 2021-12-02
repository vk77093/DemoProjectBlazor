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
    public class SubCategoryRepo : ISubCategoryRepo
    {
        private readonly DataBaseContext dataBase;

        public SubCategoryRepo(DataBaseContext dataBase)
        {
            this.dataBase = dataBase;
        }
        public IEnumerable<SubCategory> GetSubCategories()
        {
            return dataBase.SubCategories.ToList();
        }
        public void AddSubCategory(SubCategory subCategory)
        {
            subCategory.SubCategoryCode = GetSubCategoryCode(subCategory.SubCategoryCode);
            dataBase.SubCategories.Add(subCategory);
            dataBase.SaveChanges();
        }
        public SubCategory GetSubCategoryById(int subCatId)
        {
            var findCateid = dataBase.SubCategories.Find(subCatId);
            if (findCateid != null)
            {
                return findCateid;
            }
            else
            {
                return null;
            }
        }
        public void UpdateSubCategory(SubCategory subCategory)
        {
            var findUpId = dataBase.SubCategories.Find(subCategory.SubCategoryId);
            if (findUpId != null)
            {
                findUpId.CategoryId = subCategory.CategoryId;
                findUpId.SubCategoryCode = subCategory.SubCategoryCode;
                findUpId.SubCategoryName = subCategory.SubCategoryName;
                findUpId.UpdatedAt = DateTime.Now;
                dataBase.SaveChanges();
            }
            else
            {
                return;
            }
        }
        public void DeleteSubcategory(int subCateId)
        {
            var subId = dataBase.SubCategories.Find(subCateId);
            if (subId == null) return;
            dataBase.SubCategories.Remove(subId);
            dataBase.SaveChanges();
        }
        public bool AlreadyExistSubCategory(SubCategory subCategory)
        {
            var SubCatCodeAndName = dataBase.SubCategories.FirstOrDefault(x => x.SubCategoryCode == subCategory.SubCategoryCode
              || x.SubCategoryName == subCategory.SubCategoryName);
            if (SubCatCodeAndName != null) return true;
            return false;
        }
        public string GetSubCategoryCode(string codeName)
        {
            IEnumerable<SubCategory> subCategories = GetSubCategories();

            if (subCategories.Count() <=0)
            {
                codeName = SequenceParameter.SubCategorySequence + 1;
            }
            else
            {
                foreach (var subCat in subCategories)
                {
                    int count = 1;
                    codeName = SequenceParameter.SubCategorySequence + (subCat.SubCategoryId + count++);
                }
            }
            return codeName;
        }
    }
}
