using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DigiResto;
using DigiRestoProjet.Controller;
using DigiRestoProjet.Model;
using DigiRestoProjet.View;
using Newtonsoft.Json;
using Projet_Pi_DIGIRESTO.View;

namespace DigiRestoProjet
{
    public partial class StockUserControl :UserControl
    {
        
        

        public StockUserControl()
        {
            InitializeComponent();
            ControllerCardUserControl.UpdateCatInControlUser();
            GlobalVariable.stockList.CollectionChanged += StockList_CollectionChanged;

        }

        private void StockList_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    if (GlobalVariable.stockList.Count > 0)
                    {
                        panel2.Controls.Clear();
                        Load_StockDataGridView();
                    }

                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    if (GlobalVariable.stockList.Count > 0)
                    {
                        panel2.Controls.Clear();
                        Load_StockDataGridView();
                    }
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void Load_StockDataGridView()//Function to refresh dgv
        {
            var StockDataGridView = new DataGridView();
            StockdataGridView.AllowUserToAddRows = false;
            StockdataGridView.AllowUserToDeleteRows = false;
            StockdataGridView.AllowUserToResizeColumns = false;
            StockdataGridView.AllowUserToResizeRows = false;
            StockdataGridView.BackgroundColor = System.Drawing.Color.White;
            StockdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            StockdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StockdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            StockdataGridView.Location = new System.Drawing.Point(0, 0);
            StockdataGridView.MultiSelect = false;
            StockdataGridView.Name = "StockdataGridView";
            StockdataGridView.RowTemplate.Height = 25;
            StockdataGridView.Size = new System.Drawing.Size(1190, 519);
            StockdataGridView.TabIndex = 0;
            StockdataGridView.DataSource = GlobalVariable.stockList;
            panel2.Controls.Add(StockdataGridView);
        }

        public void StockUserControl_Load(object sender, EventArgs e)
        {
            StockdataGridView.DataSource = GlobalVariable.stockList;
            DataGridViewButtonColumn BtnUpdateStock = new DataGridViewButtonColumn();
            BtnUpdateStock.HeaderText = "Update";
            BtnUpdateStock.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn BtnDeleteStock = new DataGridViewButtonColumn();
            BtnDeleteStock.HeaderText = "Delete";
            BtnDeleteStock.UseColumnTextForButtonValue = true;
            StockdataGridView.Columns.Add(BtnUpdateStock);
            StockdataGridView.Columns.Add(BtnDeleteStock);
            StockdataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StockdataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StockdataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StockdataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StockdataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StockdataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void StockdataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
            if (StockdataGridView.Columns[e.ColumnIndex] == StockdataGridView.Columns[0]) //column button update was clicked 
            {
                

                string name = GlobalVariable.stockList[e.RowIndex].Name;// set value of row 
                int quantity = GlobalVariable.stockList[e.RowIndex].Quantity;
                Units unit = GlobalVariable.stockList[e.RowIndex].Unity;
                DateTime dateofperemption = GlobalVariable.stockList[e.RowIndex].DateOfPeremption;

                

                var updateStockPage = new UpdateStockPage(this);//set value in UpdateForm
                updateStockPage.UpdateStockTextBox1.Text = name;
                updateStockPage.UpdateStockDateTime.Value = dateofperemption;
                updateStockPage.QuantityTextBox3.Text = Convert.ToString(quantity);
                updateStockPage.UpdateStockcomboBox1.SelectedIndex = (int)unit;
                updateStockPage.Index = e.RowIndex;
                updateStockPage.ShowDialog();               
            }
            else if(StockdataGridView.Columns[e.ColumnIndex] == StockdataGridView.Columns[1]) //column button delete was clicked 
            {
                
                string name = GlobalVariable.stockList[e.RowIndex].Name;// set value of row in var
                int quantity = GlobalVariable.stockList[e.RowIndex].Quantity;
                Units unit = GlobalVariable.stockList[e.RowIndex].Unity;
                DateTime dateofperemption = GlobalVariable.stockList[e.RowIndex].DateOfPeremption;
   
                foreach(Stock stock in GlobalVariable.stockList)// check in list witch stock must be delete  
                {
                    if(stock.Name == name && stock.Quantity == quantity && stock.Unity == unit && stock.DateOfPeremption == dateofperemption)
                    {
                        GlobalVariable.stockList.RemoveAt(e.RowIndex); //remove stock 
                        break;
                    }
                }

                MessageBox.Show(" The Stock with Name: " + name + " Quantity: " + quantity + unit + " Date of Perenption: " + dateofperemption +" was deleted");
                StockdataGridView.Refresh();
            }
        }
        private bool IsANonHeaderLinkCell(DataGridViewCellEventArgs cellEvent)
        {
            if (StockdataGridView.Columns[cellEvent.ColumnIndex] is
                DataGridViewLinkColumn &&
                cellEvent.RowIndex != -1) { 
             return true; 
            }else{ 
                return false; 
            }
        }

        private bool IsANonHeaderButtonCell(DataGridViewCellEventArgs cellEvent)
        {
            if (StockdataGridView.Columns[cellEvent.ColumnIndex] is
                DataGridViewButtonColumn &&
                cellEvent.RowIndex != -1)
            { return true; }
            else { return (false); }
        }

        private void BtnAddStock_Click(object sender, EventArgs e)
        {
           var AddStockPage =  new AddStockPage(StockdataGridView);
            AddStockPage.ShowDialog();
        }
        
        private void BtnDeleteStock_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button delete click");

        }

        

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void StockdataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void BtnSetting_Click(object sender, EventArgs e)
        {
            var settingpage = new SettingsPage();
            settingpage.ShowDialog();
            settingpage.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            CardUserControl1.Instance.Dock = DockStyle.Fill;
            MainPage.mainPanel.Controls.Clear();
            MainPage.mainPanel.Controls.Add(CardUserControl1.Instance);
        }
    }
}
