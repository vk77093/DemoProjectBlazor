using KalaShree.models.Masters;
using System.Collections.Generic;

namespace KalaShree.Controllers.UseCases.MasterUseCase
{
    public interface IGetCategoryForSubCategoryUseCase
    {
        IEnumerable<Category> GetAllCategories();
    }
}