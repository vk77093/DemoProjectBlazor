using KalaShree.models.Masters;
using System.Collections.Generic;

namespace KalaShree.Controllers.UseCases.MasterUseCase
{
    public interface IGetSubCategoryUseCase
    {
        IEnumerable<SubCategory> GetSubCategoriesForArticle();
    }
}