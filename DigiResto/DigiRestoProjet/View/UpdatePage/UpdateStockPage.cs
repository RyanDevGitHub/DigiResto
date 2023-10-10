using DigiRestoProjet;
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

namespace Projet_Pi_DIGIRESTO.View
{
    public partial class UpdateStockPage : Form
    {
        private int _index;
        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }
        private StockUserControl _stockUserControl;
        public StockUserControl StockUserControlProperty{
            get { return _stockUserControl; }
            set { _stockUserControl = value; }
        }


        public UpdateStockPage(StockUserControl stockUserControl)
        {
            InitializeComponent();
            InitializeCombobox();
            StockUserControlProperty = stockUserControl;
        }
        private void InitializeCombobox()
        {
            UpdateStockcomboBox1.Items.AddRange(Enum.GetNames(typeof(Units)));
            UpdateStockcomboBox1.DataSource = Enum.GetValues(typeof(Units));
        }

        private void UpdateStockPage_Load(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnUpdateStock_Click(object sender, EventArgs e)
        {

            GlobalVariable.stockList[_index].Name = UpdateStockTextBox1.Text;
            GlobalVariable.stockList[_index].DateOfPeremption = UpdateStockDateTime.Value;
            GlobalVariable.stockList[_index].Quantity = Convert.ToInt32(QuantityTextBox3.Text);
            MessageBox.Show("You Stock as been update");
            StockUserControlProperty.Load_StockDataGridView();
            this.Close();

        }
    }
}
