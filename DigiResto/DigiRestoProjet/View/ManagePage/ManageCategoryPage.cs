using DigiRestoProjet.Controller;
using DigiRestoProjet.Model;
using DigiRestoProjet.View.AddPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiRestoProjet.View
{
    public partial class ManageCategoryPage : Form
    {
        //Attribut 
        public Category catSelected;  
        public int indexCatSelected { get; set; }
        

        //Constructor
        public ManageCategoryPage()
        {
            InitializeComponent();
            ControllerManageCategory.InitializeCatCombobox(this.comboBoxCategory);
        }
        //Methode


        private void textBoxMenu_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddMenu_Click(object sender, EventArgs e)
        {
            AddCategoryPage newAddCategoryPage = new AddCategoryPage();
            this.Hide();
            newAddCategoryPage.ShowDialog();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            UpdateCategoryPage newUpdateCategoryPage = new UpdateCategoryPage();
            this.Hide();
            newUpdateCategoryPage.ShowDialog();
        }

        private void labArticle_Click(object sender, EventArgs e)
        {

        }

        private void ManageCategoryPage_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            var addCategoryPage = new AddCategoryPage();
            addCategoryPage.mangeCategoryComboBox = this.comboBoxCategory;
            addCategoryPage.ShowDialog();
        }

        private void BtnDeleteCategory_Click(object sender, EventArgs e)
        {
            catSelected = (Category)comboBoxCategory.SelectedItem;
            indexCatSelected =  GlobalVariable.categoryList.IndexOf(catSelected);
            MessageBox.Show("You category '" + GlobalVariable.categoryList[indexCatSelected].Name + "' was deleted");
            GlobalVariable.categoryList.RemoveAt(indexCatSelected);
            ControllerManageCategory.InitializeCatCombobox(this.comboBoxCategory); 
        }
        
        private void BtnUpdateCategory_Click(object sender, EventArgs e)
        {
            catSelected = (Category)comboBoxCategory.SelectedItem;
            indexCatSelected = GlobalVariable.categoryList.IndexOf(catSelected);
            UpdateCategoryPage updateCategoryPage = new UpdateCategoryPage();
            updateCategoryPage.indexCatSelected = this.indexCatSelected;
            updateCategoryPage.NameCategoryTextBox.Text = catSelected.Name;
            updateCategoryPage.comboBoxcategory = this.comboBoxCategory;
            var listArticle = catSelected.ArticleList;
            foreach(Article article in listArticle)
            {
                int indice = 0;
                foreach(Article a in GlobalVariable.articleList)
                {
                    if (a.Name == article.Name)
                    {
                        updateCategoryPage.Article_checkedListBox1.SetItemChecked(indice, true);
                    }
                    indice++;
                }
                
            }
            
            
      
            updateCategoryPage.ShowDialog();
        }
    }
}
