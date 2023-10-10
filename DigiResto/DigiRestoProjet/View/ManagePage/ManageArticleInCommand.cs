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

namespace DigiRestoProjet.View.ManagePage
{
    public partial class ManageArticleInCommand : Form
    {
        public ManageArticleInCommand()
        {
            InitializeComponent();
            LoadOrderInfo();
        }
        #region methods

        void LoadOrderInfo()
        {
            ArticleInCommand article = ArticleInCommandController.Instance.LoadArticle();

            tbArticleID.Text = article.ArticleId.ToString();
            tbArticleName.Text = article.ArticleName.ToString();
            tbArticleQuantity.Text = article.Quantity.ToString();
            tbPrice.Text = article.Price.ToString();
        }
        #endregion

        #region events
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ArticleInCommandController.Instance.UpdateArticleQuantity(Int32.Parse(tbArticleQuantity.Text.ToString()));
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("DO YOU WANT TO DELETE THIS ITEM ?", "box", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Res == DialogResult.Yes)
            {
                ArticleInCommandController.Instance.UpdateArticleQuantity(0);
                this.Hide();
            }
        }
        #endregion

        private void label4_Click(object sender, EventArgs e)
        {

        }

        
    }
}
