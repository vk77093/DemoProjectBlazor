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
    public class ArticleRepo : IArticleRepo
    {
        private readonly DataBaseContext dataBase;

        public ArticleRepo(DataBaseContext dataBase)
        {
            this.dataBase = dataBase;
        }
        public IEnumerable<Article> GetArticles()
        {
            return dataBase.Articles.ToList();
        }
        public void AddArticle(Article article)
        {
            try
            {   
                article.ArticleCode = GetNextArticleCode(article.ArticleCode);
                dataBase.Articles.Add(article);
                var saveStatus = dataBase.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

        }
        public Article GetArticleById(int articleId)
        {
            var findedId = dataBase.Articles.Find(articleId);
            if (findedId == null) return null;
            return findedId;
        }
        public void UpdateArticle(Article article)
        {
            var gettedId = GetArticleById(article.ArticleId);
            if (gettedId == null) return;
            gettedId.ArticleCode = article.ArticleCode;
            gettedId.ArticleDescription = article.ArticleDescription;
            gettedId.ArticleName = article.ArticleName;
            gettedId.SubCategoryId = article.SubCategoryId;
            gettedId.UpdatedAt = article.UpdatedAt;

            dataBase.SaveChanges();
        }
        public void DeleteArticle(int articleId)
        {
            var gettedId = GetArticleById(articleId);
            if (gettedId == null) return;
            dataBase.Articles.Remove(gettedId);
            dataBase.SaveChanges();
        }
        public bool IsAlreadyExists(Article article)
        {
            var articleCodeAndName = dataBase.Articles.FirstOrDefault(x => x.ArticleCode == article.ArticleCode
              || x.ArticleName == article.ArticleName);
            if (articleCodeAndName != null) return true;
            return false;
        }
       public string GetNextArticleCode(string id)
        {
            IEnumerable<Article> articles = GetArticles();
            if(articles.Count() <=0)
            {
                id = "A"+1;
            }
            else
            {
                foreach (var art in articles)
                {
                    int count = 1;
                    id = "A" + (art.ArticleId+count++);
                }
            }
         
            
            return id;
        }
            
    }
}
