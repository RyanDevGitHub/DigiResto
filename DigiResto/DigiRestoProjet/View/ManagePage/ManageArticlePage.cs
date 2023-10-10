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
    public partial class ManageArticlePage : Form
    {

        public Article ArticleSelected;
        public int IndexArticleSelected { get; set; }
        public ManageArticlePage()
        {
            InitializeComponent();
            ControllerManageArticlePage.UpdateArticleInComboBox(this,this.comboBoxArticle);
        }

        private void BtnAddArticle_Click(object sender, EventArgs e)
        {
            AddArticlePage articlePage = new();
            articlePage.manageArticlePage = this;
            articlePage.manageArticleComboBox= this.comboBoxArticle;
            articlePage.ShowDialog();
        }

        private void BtnDeleteArticle_Click(object sender, EventArgs e)
        {
            
            ControllerManageArticlePage.DeleteArticle(this, this.comboBoxArticle);
            ControllerManageArticlePage.UpdateArticleInComboBox(this,this.comboBoxArticle); 
        }

        private void BtnUpdateArticle_Click(object sender, EventArgs e)
        {
            ControllerManageArticlePage.OpenAndSetUpdatePage(this, this.comboBoxArticle);
        }
    }
}
