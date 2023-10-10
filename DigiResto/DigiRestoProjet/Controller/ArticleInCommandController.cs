using DigiRestoProjet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DigiRestoProjet.Controller
{
    public class ArticleInCommandController
    {
        private static ArticleInCommandController? instance;
        public static ArticleInCommandController Instance
        {
            get { if (instance == null) instance = new ArticleInCommandController(); return instance; }
            set { instance = value; }
        }

        public ArticleInCommand LoadArticle()
        {
            string fileName = "..\\..\\..\\Json\\ArticleInCommand.json";
            string jsonString = File.ReadAllText(fileName);
            ArticleInCommand article = JsonSerializer.Deserialize<ArticleInCommand>(jsonString)!;
            
            return article;
        }
        public bool AddArticle(/*int articleId,*/ string articleName, int quantity, float total)
        {
            string fileName = "..\\..\\..\\Json\\ArticleInCommand.json";
            string jsonString = File.ReadAllText(fileName);
            ArticleInCommand article = JsonSerializer.Deserialize<ArticleInCommand>(jsonString)!;

            //article.ArticleId = articleId;
            article.ArticleName = articleName;
            article.Quantity = quantity;
            article.Price = total;

            string newJson = JsonSerializer.Serialize(article);
            File.WriteAllText(fileName, newJson);
            return true;
        }
        public bool UpdateArticleQuantity(int quantity)
        {
            string fileName = "..\\..\\..\\Json\\ArticleInCommand.json";
            string jsonString = File.ReadAllText(fileName);
            ArticleInCommand article = JsonSerializer.Deserialize<ArticleInCommand>(jsonString)!;
            float price;
            price = article.Price / article.Quantity;
            article.Quantity = quantity;
            article.Price = price * quantity;

            string newJson = JsonSerializer.Serialize(article);
            File.WriteAllText(fileName, newJson);

            return true;
        }
    }
}
