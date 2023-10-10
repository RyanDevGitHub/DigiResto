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
    public partial class AddTablePage : Form
    {
        //attribut property
        
        
        //constructor
        public AddTablePage()
        {
            InitializeComponent();
        }

        private void MenuArticle_checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddNewArticle_Click(object sender, EventArgs e)
        {
            


        }

        private void labArticle_Click(object sender, EventArgs e)
        {

        }

        private void MenuArticle_checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void BtnAddNewTable_Click(object sender, EventArgs e)
        {
            int size = Convert.ToInt32(SizeTableTextBox.Text);


            var newTable = new Table(size);
            if(newTable != null)
            {
                GlobalVariable.tableList.Add(newTable);
                MessageBox.Show("Your Table wad add !!");
                this.Close();

            }
            
        }

        private void DescArticleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddArticlePage_Load(object sender, EventArgs e)
        {

        }
    }
}
