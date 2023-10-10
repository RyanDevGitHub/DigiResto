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
    public partial class ManageTablePage : Form
    {
        //Attribut 
        public Table tabSelected;  
        public int indexTabSelected { get; set; }
        

        //Constructor
        public ManageTablePage()
        {
            InitializeComponent();
            ControllerManageTable.UpdateInitManageTableComboBox(this.comboBoxTable);
            GlobalVariable.tableList.CollectionChanged += TableList_CollectionChanged;

        }
        //Methode


        private void TableList_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    ControllerManageTable.UpdateInitManageTableComboBox(this.comboBoxTable);
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    ControllerManageTable.UpdateInitManageTableComboBox(this.comboBoxTable);
                    break;
            }
        }


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

        private void BtnAddTable_Click(object sender, EventArgs e)
        {
            var addTablePage = new AddTablePage();
            addTablePage.ShowDialog();
        }

        private void BtnDeleteTable_Click(object sender, EventArgs e)
        {
            if (comboBoxTable.Items.Count > 0)
            {
                tabSelected = (Table)comboBoxTable.SelectedItem;
                indexTabSelected = GlobalVariable.tableList.IndexOf(tabSelected);
                MessageBox.Show("You table ID '" + GlobalVariable.tableList[indexTabSelected].Id + "' was deleted");
                GlobalVariable.tableList.RemoveAt(indexTabSelected);
                
            }
          
        }
        
        private void BtnUpdateTable_Click(object sender, EventArgs e)
        {
            tabSelected = (Table)comboBoxTable.SelectedItem;
            indexTabSelected = GlobalVariable.tableList.IndexOf(tabSelected);
            UpdateTablePage updateTablePage = new UpdateTablePage();
            updateTablePage.indexTabSelected = this.indexTabSelected;
            var sizestring = Convert.ToString(tabSelected.Size);    
            updateTablePage.SizeUpdateTextBox.Text = sizestring;
            updateTablePage.ShowDialog();
        }
    }
}
