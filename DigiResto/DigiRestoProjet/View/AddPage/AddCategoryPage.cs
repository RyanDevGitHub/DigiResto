using DigiRestoProjet.Controller;
using DigiRestoProjet.Model;
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
    public partial class AddCategoryPage : Form
    {
        public Panel mainPanel;
        //attribut property
        private string _nameOfCategory;
        private Color backgroundColorCategory;
        public ComboBox mangeCategoryComboBox;
        public string NameOfCategory{ 
            get { return _nameOfCategory;}
            set { _nameOfCategory = value;}
        }
        
        //constructor
        public AddCategoryPage()
        {
            InitializeComponent();
            var ArticleList = GlobalVariable.articleList;
                foreach (Article item in ArticleList)
                {
                    MenuArticle_checkedListBox1.Items.Add(item);
                    MenuArticle_checkedListBox1.DisplayMember = "Name";
                }
            foreach (Menu item in GlobalVariable.menuList)
            {
                Menu_checkedListBox1.Items.Add(item);
                Menu_checkedListBox1.DisplayMember = "Name";
            }
        }

        private void MenuArticle_checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddNewCategory_Click(object sender, EventArgs e)
        {
            string nameCategory = NameCategoryTextBox.Text;
            List<Article> listArticle = new List<Article>();
            List<Menu> listMenu = new List<Menu>();
            foreach (Article item in MenuArticle_checkedListBox1.CheckedItems)
            {

                listArticle.Add(item);

            }
            foreach (Menu item in Menu_checkedListBox1.CheckedItems)
            {

                listMenu.Add(item);

            }
            if (listArticle.Count != 0 || listMenu.Count != 0)
            {
                if (nameCategory != null)
                {
                    
                    var newCategory = new Category(nameCategory, listArticle, backgroundColorCategory, listMenu);
                    GlobalVariable.categoryList.Add(newCategory);
                    ControllerManageCategory.InitializeCatCombobox(this.mangeCategoryComboBox);
                    if (GlobalVariable.categoryList.Count > 0)
                    {
                        ControllerCardUserControl.DisplayArticleMenu(GlobalVariable.categoryList[0], CardUserControl1.Instance.TblDisplayArticle, CardUserControl1.Instance);
                    }
                    MessageBox.Show("You category was had with succes !");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("You must choice a name for you new Category");
                }
            }
            else
            {
                MessageBox.Show("You must choice minimum 1 Article to create a Category");
            }
            
        }

        private void BtnColorCategory_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            backgroundColorCategory = colorDialog1.Color ;

        }

        private void AddCategoryPage_Load(object sender, EventArgs e)
        {

        }
    }
}
