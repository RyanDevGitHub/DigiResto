using DigiRestoProjet.Model;
using DigiRestoProjet.Model.custom_control;
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

namespace DigiRestoProjet.View.AddPage
{
    public partial class AddMenuPage : Form
    {
        public AddMenuPage()
        {
            InitializeComponent();
            for (int i = 0; i < GlobalVariable.articleList.Count; i++)
            {
                CCBoxItem item = new CCBoxItem(GlobalVariable.articleList[i].Name, GlobalVariable.articleList[i]);
                checkedComboBoxEnter.Items.Add(item);
            }
            // If more then 5 items, add a scroll bar to the dropdown.
            checkedComboBoxEnter.MaxDropDownItems = 5;
            // Make the "Name" property the one to display, rather than the ToString() representation.
            checkedComboBoxEnter.DisplayMember = "Name";
            checkedComboBoxEnter.ValueSeparator = ", ";


            for (int i = 0; i < GlobalVariable.articleList.Count; i++)
            {
                CCBoxItem item = new CCBoxItem(GlobalVariable.articleList[i].Name, GlobalVariable.articleList[i]);
                checkedComboBoxDish.Items.Add(item);
            }
            // If more then 5 items, add a scroll bar to the dropdown.
            checkedComboBoxDish.MaxDropDownItems = 5;
            // Make the "Name" property the one to display, rather than the ToString() representation.
            checkedComboBoxDish.DisplayMember = "Name";
            checkedComboBoxDish.ValueSeparator = ", ";



            for (int i = 0; i < GlobalVariable.articleList.Count; i++)
            {
                CCBoxItem item = new CCBoxItem(GlobalVariable.articleList[i].Name, GlobalVariable.articleList[i]);
                checkedComboBoxDessert.Items.Add(item);
            }
            // If more then 5 items, add a scroll bar to the dropdown.
            checkedComboBoxDessert.MaxDropDownItems = 5;
            // Make the "Name" property the one to display, rather than the ToString() representation.
            checkedComboBoxDessert.DisplayMember = "Name";
            checkedComboBoxDessert.ValueSeparator = ", ";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAddNewArticle_Click(object sender, EventArgs e)
        {
            string namemenu = NameMenuTextBox.Text;
            string descriptionmenu = DescMenuTextBox.Text;
            double pricemenu = Convert.ToInt32(PriceMenuTextBox.Text);
            ObservableCollection<Article> enterlist = new ObservableCollection<Article>();
            ObservableCollection<Article> dishlist = new ObservableCollection<Article>();
            ObservableCollection<Article> dessertlist = new ObservableCollection<Article>();
            var comoboboxDessert = checkedComboBoxDessert.CheckedItems;
            var comoboboxEnter = checkedComboBoxEnter.CheckedItems;
            var comoboboxDish = checkedComboBoxDish.CheckedItems;

            foreach( CCBoxItem article in checkedComboBoxEnter.CheckedItems)
            {
                enterlist.Add((Article)article.Value);
            }
            foreach (CCBoxItem article in checkedComboBoxDish.CheckedItems)
            {
               dishlist.Add((Article)article.Value);
            }
            foreach (CCBoxItem article in checkedComboBoxDessert.CheckedItems)
            {
                dessertlist.Add((Article)article.Value);
            }
            var newmenu = new Menu(namemenu, descriptionmenu, pricemenu, enterlist, dishlist, dessertlist);
            GlobalVariable.menuList.Add(newmenu);
            MessageBox.Show("Menu Add");
            this.Close();
        }
    }
}
