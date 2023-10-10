using DigiRestoProjet.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DigiRestoProjet.Controller
{
    public class ArticleMenuController
    {
        private static ArticleMenuController instance;
        public static ArticleMenuController Instance
        {
            get { if(instance == null) instance = new ArticleMenuController(); return instance; }   
            set { instance = value; }
        }

        public List<ArticleMenu> LoadArticleMenu()
        {
            string fileName = "..\\..\\..\\Json\\ArticleMenu.json";
            string jsonString = File.ReadAllText(fileName);
            List<ArticleMenu> list = JsonSerializer.Deserialize<List<ArticleMenu>>(jsonString)!;

            return list;
        }
        public List<ArticleMenu> CheckArticleMenu(List<ArticleMenu> foods)
        {
            string fileName = "..\\..\\..\\Json\\ArticleMenu.json";
            string jsonString = File.ReadAllText(fileName);
            List<ArticleMenu> list = JsonSerializer.Deserialize<List<ArticleMenu>>(jsonString)!;

            List<ArticleMenu> addList = new List<ArticleMenu>();
            bool isExit = false;
            if (list.Count > 0)
            {
                foreach (ArticleMenu item in foods)
                {
                    foreach (ArticleMenu menu in list)
                    {
                        if (item.FoodName.Equals(menu.FoodName))
                        {
                            menu.Quantity += item.Quantity;
                            isExit = true;
                            break;
                        }
                    }
                    if(!isExit)
                        addList.Add(item);
                }
                foreach(ArticleMenu a in addList)
                {
                    list.Add(a);
                }
            }
            else
            {
                list = foods;
            }
            
            string newJson = JsonSerializer.Serialize(list);
            File.WriteAllText(fileName, newJson);
            return list;
        }
        public bool SetArticleMenu()
        {
            string fileName = "..\\..\\..\\Json\\ArticleMenu.json";
            string jsonString = File.ReadAllText(fileName);
            List<ArticleMenu> list = JsonSerializer.Deserialize<List<ArticleMenu>>(jsonString)!;
            if(list != null)
            {
                list.Clear();
                string newJson = JsonSerializer.Serialize(list);
                File.WriteAllText(fileName, newJson);
            }
            return true;
        }
    }
}
