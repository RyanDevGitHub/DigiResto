using DigiRestoProjet.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DigiRestoProjet.Controller
{
    public class ArticleController
    {
        private static ArticleController instance;
        public static ArticleController Instance
        {
            get { if (instance == null) instance = new ArticleController(); return instance; }
            set { instance = value; }
        }
        public List<Article> LoadArticle()
        {
            var path = Directory.GetParent(System.Environment.CurrentDirectory).Parent.Parent.FullName;
            string fileName = path + "\\Json\\Article.json";
            if (File.Exists(fileName))
            {
                var articleList = JsonConvert.DeserializeObject<List<Article>>(File.ReadAllText(fileName));
                return articleList;
            }
            return null;
        }

        public Article GetArticleByName(String articleName)
        {
            var path = Directory.GetParent(System.Environment.CurrentDirectory).Parent.Parent.FullName;
            string fileName = path + "\\Json\\Article.json";

            if (File.Exists(fileName))
            {
                //var articleList = JsonConvert.DeserializeObject<List<Article>>(File.ReadAllText(fileName));
                Article article = GlobalVariable.articleList.Where(p => p.Name == articleName).FirstOrDefault();
                return article;
            }
            return null;
        }
        public string GetNameArticleById(int id)
        {
            var path = Directory.GetParent(System.Environment.CurrentDirectory).Parent.Parent.FullName;
            string fileName = path + "\\Json\\Article.json";

            if (File.Exists(fileName))
            {
                //var articleList = JsonConvert.DeserializeObject<List<Article>>(File.ReadAllText(fileName));
                Article article = GlobalVariable.articleList.Where(p => p.Id == id).FirstOrDefault();
                string articleName = article.Name;
                return articleName;
            }
            return null;
        }
        public List<Ingredient> GetIngredientList(string name)
        {
            var path = Directory.GetParent(System.Environment.CurrentDirectory).Parent.Parent.FullName;
            string fileName = path + "\\Json\\Article.json";

            if (File.Exists(fileName))
            {
                //var articleList = JsonConvert.DeserializeObject<List<Article>>(File.ReadAllText(fileName));
                Article article = GlobalVariable.articleList.Where(p => p.Name == name).FirstOrDefault();
                List<Ingredient> ingredientList = article._ingredientList;

                return ingredientList;
            }
            return null;
        }
    }
}
