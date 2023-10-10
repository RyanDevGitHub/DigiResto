using DigiRestoProjet.Controller;
using DigiRestoProjet.Model;
using DigiRestoProjet.Model.custom_control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace DigiRestoProjet.View.AddPage
{
    public partial class AddArticlePage : Form
    {
        //attribut property
        public ManageArticlePage manageArticlePage;
        public ComboBox manageArticleComboBox;


        //constructor
        public AddArticlePage()
        {
            InitializeComponent();
            dataGridViewAddArticle.DataSource = GlobalVariable.ingredientList;
            for (int i = 0;i < dataGridViewAddArticle.Columns.Count; i++)
            {
                dataGridViewAddArticle.Columns[i].Visible = false;
            }
            dataGridViewAddArticle.Columns["Name"].Visible = true ;
            dataGridViewAddArticle.Columns["Name"].DisplayIndex = 0;
            dataGridViewAddArticle.Columns["Name"].ReadOnly= true ;
            dataGridViewAddArticle.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewAddArticle.Columns["CheckBoxColumn"].Visible = true;
            dataGridViewAddArticle.Columns["CheckBoxColumn"].DisplayIndex = 1;
            dataGridViewAddArticle.Columns["QuantityColumn"].Visible = true;
            dataGridViewAddArticle.Columns["QuantityColumn"].DisplayIndex = 2;
            dataGridViewAddArticle.Columns["UnitColumn"].Visible = true;
            dataGridViewAddArticle.Columns["UnitColumn"].DisplayIndex = 3;

        }
        private void BtnAddNewArticle_Click(object sender, EventArgs e)
        {
            string name = NameArticleTextBox.Text;
            string description = DescArticleTextBox.Text;
            double price = Convert.ToDouble(PriceArticleTextBox.Text);
            List<Ingredient> checkedList = new();
            foreach (DataGridViewRow row in dataGridViewAddArticle.Rows)
            {

              var checkbox  = row.Cells["CheckBoxColumn"].Value;
            if(checkbox != null)
                {
                    if ((bool)checkbox == true)
                    {
                        var namerow = row.Cells["Name"].Value;
                        var quantity = row.Cells["QuantityColumn"].Value;
                        var unit = row.Cells["UnitColumn"].Value;
                        Enum.TryParse((string)unit, out Units unitValue);
                        var newingredient = new Ingredient((string)namerow,Convert.ToInt32(quantity), unitValue);
                        checkedList.Add(newingredient);
                    }
                }
            }
            var newArticle = new Article(name, description, price,checkedList);
            if (newArticle != null)
            {
                GlobalVariable.articleList.Add(newArticle);
                ControllerManageArticlePage.UpdateArticleInComboBox(manageArticlePage, manageArticleComboBox);
                MessageBox.Show("Your Article wad add !!");
                this.Close();
            }
        }

        private void checkBoxListWithTextBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxListWithTextBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NameArticleTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}