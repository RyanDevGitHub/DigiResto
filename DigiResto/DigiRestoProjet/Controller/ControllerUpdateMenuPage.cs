using CheckComboBoxTest;
using DigiRestoProjet.Model;
using DigiRestoProjet.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiRestoProjet.Controller
{
    public class ControllerUpdateMenuPage
    {
        public static void InitCheckComboBox(Menu menu,CheckedComboBox enter, CheckedComboBox dish, CheckedComboBox dessert)
        {
            foreach (Article article in GlobalVariable.articleList)
            {
                bool dishUse = true;
                bool enterUse = true;
                bool dessertUse = true;

                if (menu.DessertArticle.Any(x => x.Name == article.Name))
                {
                    dessert.Items.Add(article, true);
                    dessert.DisplayMember = "Name";
                    dessertUse = false;
                }
                if (menu.DishArticle.Any(x => x.Name == article.Name))
                {
                    dish.Items.Add(article, true);
                    dish.DisplayMember = "Name";
                    dishUse = false;
                }
                if (menu.EnterArticle.Any(x => x.Name == article.Name))
                {
                    enter.Items.Add(article, true);
                    enter.DisplayMember = "Name";
                    enterUse = false;
                }
                if (dishUse == true)
                {
                    dish.Items.Add(article);
                }
                if (enterUse == true)
                {
                    enter.Items.Add(article);

                }
                if (dessertUse == true)
                {
                    dessert.Items.Add(article);
                }
                dessert.DisplayMember = "Name";
                dish.DisplayMember = "Name";
                enter.DisplayMember = "Name";
            }
        }
    }
}
