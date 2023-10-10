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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DigiRestoProjet.View
{
    public partial class UpdateArticlePage : Form
    {
        private int _indexArticleSelected;
        public int IndexArticleSelected
        {
            get { return _indexArticleSelected; }
            set { _indexArticleSelected = value; } 
        }
        private ManageArticlePage _manageArticlePage;
        public ManageArticlePage ManageArticlePage
        {
            get { return _manageArticlePage; }
            set { _manageArticlePage = value; }
        }
        private System.Windows.Forms.ComboBox _comboBoxManageArticlePage;
        public System.Windows.Forms.ComboBox ComboBoxManageArticlePage
        {
            get { return _comboBoxManageArticlePage; }
            set { _comboBoxManageArticlePage = value; }
        }
   

        public UpdateArticlePage()
        {
            InitializeComponent();
            NameArticleUpdateTextBox.Text = GlobalVariable.articleList[IndexArticleSelected].Name;
            DescArticleUpdateTextBox.Text = GlobalVariable.articleList[IndexArticleSelected].Description;
            PriceArticleUpdateTextBox.Text = Convert.ToString(GlobalVariable.articleList[IndexArticleSelected].Price);
            ControllerUpdateArticle.InitCheckBox(this);


        }

        private void BtnUpdateCategory_Click(object sender, EventArgs e) {
            ControllerUpdateArticle.UpdateArticle(this);
            ControllerManageArticlePage.UpdateArticleInComboBox(ManageArticlePage,ComboBoxManageArticlePage);
            
        }

        private void UpdateArticlePage_Load(object sender, EventArgs e)
        {

        }

        private void PriceArticleUpdateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DescArticleTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
