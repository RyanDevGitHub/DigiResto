

using DigiRestoProjet.Model;
using DigiRestoProjet.View;
using DigiRestoProjet.View.AddPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiRestoProjet.Controller
{
    internal class ControllerManageArticlePage
    {
        public static void UpdateArticleInComboBox(ManageArticlePage manageArticlePage, ComboBox manageArticleComboBox ) //for Update and Init
        {
            // comboBoxCategory.Items.AddRange();
            if (GlobalVariable.articleList.Count > 0)
            {
                manageArticleComboBox.Items.Clear();    
               foreach(Article a in GlobalVariable.articleList)
                {
                    manageArticleComboBox.Items.Add(a);
                    manageArticleComboBox.ValueMember = "Name";
                }
                
                manageArticleComboBox.SelectedIndex = 0;
            }
            else
            {
                manageArticleComboBox.Items.Clear();
            }
        }
        public static void OpenAndSetUpdatePage(ManageArticlePage manageArticlePage, ComboBox manageArticleComboBox)
        {
            if (manageArticleComboBox.Items.Count > 0)
            {
                manageArticlePage.ArticleSelected = (Article)manageArticleComboBox.SelectedItem;
                manageArticlePage.IndexArticleSelected = GlobalVariable.articleList.IndexOf(manageArticlePage.ArticleSelected);
                UpdateArticlePage updateArticlePage = new UpdateArticlePage();
                updateArticlePage.IndexArticleSelected = manageArticlePage.IndexArticleSelected;
                updateArticlePage.NameArticleUpdateTextBox.Text = manageArticlePage.ArticleSelected.Name;
                updateArticlePage.ComboBoxManageArticlePage = manageArticleComboBox;
                updateArticlePage.ManageArticlePage = manageArticlePage;
                ControllerUpdateArticle.InitCheckBox(updateArticlePage);
                updateArticlePage.ShowDialog();
            }
        }

        public static void DeleteArticle(ManageArticlePage manageArticlePage, ComboBox manageArticleComboBox )
        {
            if(manageArticleComboBox.Items.Count > 0)
            {
                manageArticlePage.ArticleSelected = (Article)manageArticleComboBox.SelectedItem;
                manageArticlePage.IndexArticleSelected = GlobalVariable.articleList.IndexOf(manageArticlePage.ArticleSelected);
                List<int> listarticleindicedelete = new List<int>();
                int cptcategory = 0;
                int cptarticle = 0;
                foreach (Category category in GlobalVariable.categoryList)
                {
                    foreach (Article article in category.ArticleList)
                    {
                        if (article == manageArticlePage.ArticleSelected)
                        {
                            listarticleindicedelete.Add(cptcategory);
                        }
                        cptarticle++;
                    }
                    cptcategory++;
                }
                foreach (int i in listarticleindicedelete)
                {
                    GlobalVariable.categoryList[i].ArticleList.Remove(manageArticlePage.ArticleSelected);

                }
                foreach (Category cat in GlobalVariable.categoryList)
                {
                    cat.ArticleList.Remove(manageArticlePage.ArticleSelected);
                }
                MessageBox.Show("You artcile '" + GlobalVariable.articleList[manageArticlePage.IndexArticleSelected].Name + "' was deleted");
                GlobalVariable.articleList.RemoveAt(manageArticlePage.IndexArticleSelected);
            }
        }
    }
}
