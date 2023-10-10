using DigiRestoProjet.Controller;
using DigiRestoProjet.Model;
using DigiRestoProjet.Model.custom_control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiRestoProjet.View.AddPage
{
    public partial class UpdateCategoryPage : Form
    {
        //attribut property
        private string _nameOfCategory;
        private Color backgroundColorCategory;
        public string NameOfCategory { 
            get { return _nameOfCategory;}
            set { _nameOfCategory = value;}
        }
        public int indexCatSelected { get; set; }
        public ComboBox comboBoxcategory;

        //constructor
        public UpdateCategoryPage()
        {
            InitializeComponent();
            if (GlobalVariable.ingredientList != null)
            {
                foreach (Article item in GlobalVariable.articleList)
                {
                    Article_checkedListBox1.Items.Add(item);
                    Article_checkedListBox1.DisplayMember = "Name";
                }
            }
            ControllerUpdateCategoryPage.InitComboboxMenu(this.Menu_checkedListBox1, GlobalVariable.categoryList[indexCatSelected]);
        }

        private void MenuArticle_checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddNewCategory_Click(object sender, EventArgs e)
        {
            string nameCategory = NameCategoryTextBox.Text;
            List<Article> listArticle = new List<Article>(); 
            List<Menu> listMenu = new List<Menu>();
            foreach(Article item in Article_checkedListBox1.CheckedItems)
            {
                listArticle.Add(item);
            }
            foreach(Menu menu in listMenu)
            {
                listMenu.Add(menu);
            }
            
            if(listArticle.Count != 0)
            {
                if (nameCategory != null)
                {
                    var newCategory = new Category(nameCategory, listArticle,backgroundColorCategory,listMenu);
                    GlobalVariable.categoryList.Add(newCategory);
                    MessageBox.Show("You category was had with succes !");
                }
            }
            else
            {
                MessageBox.Show("You must choice minimum 1 Article to create a Category");
            }
         


        }

        private void CheckBoxListTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpdateCategory_Click(object sender, EventArgs e)
        {
            var listChecked =  Article_checkedListBox1.CheckedItems;
            var menuChecked = Menu_checkedListBox1.CheckedItems;
            if (listChecked.Count != 0 || menuChecked.Count != 0)
            {
                if (NameCategoryTextBox.Text != null)
                {
                    GlobalVariable.categoryList[indexCatSelected].Name = NameCategoryTextBox.Text;
                    if (GlobalVariable.categoryList[indexCatSelected].BackgroundColor != null)
                    {
                        GlobalVariable.categoryList[indexCatSelected].BackgroundColor = backgroundColorCategory;
                    }
                    GlobalVariable.categoryList[indexCatSelected].ArticleList.Clear();
                    foreach (Article item in listChecked)
                    {
                        GlobalVariable.categoryList[indexCatSelected].ArticleList.Add(item);
                    }
                    GlobalVariable.categoryList[indexCatSelected].MenuList.Clear();
                    foreach (Menu item in Menu_checkedListBox1.CheckedItems)
                    {
                        GlobalVariable.categoryList[indexCatSelected].MenuList.Add(item);
                    }
                }

            }
            ControllerManageCategory.InitializeCatCombobox(this.comboBoxcategory);
            CategoryBox.Instance.UpdateControl();
            if (GlobalVariable.categoryList.Count > 0)
            {
                ControllerCardUserControl.DisplayArticleMenu(GlobalVariable.categoryList[0], CardUserControl1.Instance.TblDisplayArticle, CardUserControl1.Instance);
            }
            MessageBox.Show("Your category was Update ");
            this.Close();

        }

        private void BtnColorCategory_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            backgroundColorCategory = colorDialog1.Color;
        }

        private void MenuArticle_checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
