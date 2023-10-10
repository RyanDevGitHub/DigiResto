using DigiRestoProjet.Model;
using DigiRestoProjet.Model.custom_control;
using DigiRestoProjet.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiRestoProjet.Controller
{
    internal class ControllerCardUserControl
    {
        public static void DisplayArticleMenu(Category catselected, TableLayoutPanel tlpArticleMenu, CardUserControl1 cardUserControl)
        {
            tlpArticleMenu.Controls.Clear();
            int cpt = 0;
            int decalage = 0;
            int column = 0;
            foreach (Article article in catselected.ArticleList)
            {
                //create button 
                Button button = new()
                {
                    Dock = DockStyle.Fill,
                    Text = article.Name,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = System.Drawing.Color.White,
                    Tag = article.Name
                };
                button.Click += new System.EventHandler(cardUserControl.buttonArticle_Click);
                //add control in tableLayoutPanel
                int index = GlobalVariable.articleList.IndexOf(article);
                //int row = index + (index + 1);

                if (cpt == 5)
                {
                    //decalage += 5;
                    column++;
                    cpt = 0;
                    tlpArticleMenu.Controls.Add(button, cpt, column);

                }
                else
                {
                    tlpArticleMenu.Controls.Add(button, cpt, column);
                    cpt++;
                }
            }
            foreach (Menu menu in catselected.MenuList)
            {
                //create button 
                Button button = new()
                {
                    Dock = DockStyle.Fill,
                    Text = menu.Name,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = System.Drawing.Color.White,
                    Tag = menu.Name
                   
                };
                button.Tag = menu.Name;
                
                button.Click += new System.EventHandler(cardUserControl.buttonMenu_Click);
                //add control in tableLayoutPanel
                int index = GlobalVariable.menuList.IndexOf(menu);
                int row = index + (index + 1);

                if (cpt == 5)
                {
                    decalage += 5;
                    column++;
                    cpt = 0;
                    tlpArticleMenu.Controls.Add(button, row, column);

                }
                tlpArticleMenu.Controls.Add(button, row, column);
                cpt++;
            }
        }
        public static void UpdateCatInControlUser()
        {
            CategoryBox.Instance.UpdateControl();
        }
        public static void deleteArticleinCategory(Article a)
        {
            List<Article> deletelist = new ();
            foreach (Category cat in GlobalVariable.categoryList)
            {
                foreach (Article article in cat.ArticleList)
                {
                    if (article.Name == a.Name)
                    {
                        deletelist.Add(article);
                    }

                }
                foreach (Article deleteArticle in deletelist)
                {
                        cat.ArticleList.Remove(deleteArticle);
                }
            }

        }
    }
}
