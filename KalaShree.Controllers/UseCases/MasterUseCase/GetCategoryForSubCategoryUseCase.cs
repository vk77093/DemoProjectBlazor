using KalaShree.Controllers.InterFaces;
using KalaShree.models.Masters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalaShree.Controllers.UseCases.MasterUseCase
{
    public class GetCategoryForSubCategoryUseCase : IGetCategoryForSubCategoryUseCase
    {
        private readonly ICategoryRepo categoryRepo;

        public GetCategoryForSubCategoryUseCase(ICategoryRepo categoryRepo)
        {
            this.categoryRepo = categoryRepo;
        }
        public IEnumerable<Category> GetAllCategories()
        {
            return categoryRepo.GetCategories();
        }
    }
}
