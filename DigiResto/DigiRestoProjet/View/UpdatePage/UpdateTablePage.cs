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
    public partial class UpdateTablePage : Form
    {
        //attribut property
        public int indexTabSelected { get; set; }

        //constructor
        public UpdateTablePage()
        {
            InitializeComponent();
        }

        private void MenuArticle_checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddNewTable_Click(object sender, EventArgs e)
        {
            int sizeTable = Convert.ToInt32(this.SizeUpdateTextBox.Text);
            if (sizeTable != null)
            {
                var newTable = new Table (sizeTable);
                GlobalVariable.tableList.Add(newTable);
                MessageBox.Show("You table was had with succes !");
            }
            else
            {
                MessageBox.Show("You must choice a size for you new Table ");
            }
         


        }

        private void CheckBoxListTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpdateTable_Click(object sender, EventArgs e)
        {

            GlobalVariable.tableList[indexTabSelected].Size = Convert.ToInt32(this.SizeUpdateTextBox.Text);
                MessageBox.Show("Your table was Update ");
            this.Close();

        }

       

        private void UpdateTablePage_Load(object sender, EventArgs e)
        {

        }
    }
}
