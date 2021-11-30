using KalaShree.models.Masters;
using System.Collections.Generic;

namespace KalaShree.Controllers.InterFaces
{
    public interface IArticleRepo
    {
        void AddArticle(Article article);
        void DeleteArticle(int articleId);
        Article GetArticleById(int articleId);
        IEnumerable<Article> GetArticles();
        bool IsAlreadyExists(Article article);
        void UpdateArticle(Article article);
    }
}