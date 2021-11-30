using KalaShree.Controllers.InterFaces;
using KalaShree.models.Masters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalaShree.Controllers.UseCases.MasterUseCase
{
    public class GetSubCategoryUseCase : IGetSubCategoryUseCase
    {
        private readonly ISubCategoryRepo subCategoryRepo;

        public GetSubCategoryUseCase(ISubCategoryRepo subCategoryRepo)
        {
            this.subCategoryRepo = subCategoryRepo;
        }
        public IEnumerable<SubCategory> GetSubCategoriesForArticle()
        {
            return subCategoryRepo.GetSubCategories();
        }
    }
}
