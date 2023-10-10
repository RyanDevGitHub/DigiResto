using DigiRestoProjet.Controller;
using DigiRestoProjet.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiRestoProjet.View
{
    public partial class MenuPage : Form
    {
        public MenuPage(string menuname,ObservableCollection<Article>dishlist,ObservableCollection<Article>enterlist,ObservableCollection<Article>dessertList)
        {
            InitializeComponent();
            this.label1.Text = menuname;
            foreach(Article ent in dishlist)
            {
                this.checkedListBoxdish.Items.Add(ent);
                this.checkedListBoxdish.DisplayMember = "Name";


            }
            foreach (Article ent in enterlist)
            {
                this.checkedListBoxenter.Items.Add(ent);
                this.checkedListBoxenter.DisplayMember = "Name";
            }
            foreach (Article ent in dessertList)
            {
                this.checkedListBoxdessert.Items.Add(ent);
                this.checkedListBoxdessert.DisplayMember = "Name";
            }
           
        }

        private void BtnsaveMenu_Click(object sender, EventArgs e)
        {
            List<ArticleMenu> list = new List<ArticleMenu>();

            if(checkedListBoxenter.CheckedItems.Count > 0)
            {
                foreach(Article ent in checkedListBoxenter.CheckedItems)
                {
                    ArticleMenu foods = new ArticleMenu();

                    foods.FoodName = ent.Name;
                    foods.Quantity = 1;
                    list.Add(foods);
                }
            }
            if (checkedListBoxdish.CheckedItems.Count > 0)
            {
                foreach (Article ent in checkedListBoxdish.CheckedItems)
                {
                    ArticleMenu foods = new ArticleMenu();

                    foods.FoodName = ent.Name;
                    foods.Quantity = 1;
                    list.Add(foods);
                }
            }
            if (checkedListBoxdessert.CheckedItems.Count > 0)
            {
                foreach (Article ent in checkedListBoxdessert.CheckedItems)
                {
                    ArticleMenu foods = new ArticleMenu();

                    foods.FoodName = ent.Name;
                    foods.Quantity = 1;
                    list.Add(foods);
                }
            }

            List<ArticleMenu> newList = ArticleMenuController.Instance.CheckArticleMenu(list);
            this.Hide();
        }
    }
}
