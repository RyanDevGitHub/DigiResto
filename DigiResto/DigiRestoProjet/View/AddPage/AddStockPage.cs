
using DigiResto;
using DigiRestoProjet;
using DigiRestoProjet.Model;
using DigiRestoProjet.Controller;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace Projet_Pi_DIGIRESTO.View
{
    public partial class AddStockPage : Form
    {
        string name;
        int quantity;
        Units units;
        DateTime dateOfPeremption;
        string jsonString;
        DataGridView stockgrid;
        
        
        
        
        public AddStockPage(DataGridView stock)
        {
            InitializeComponent();
            InitializeCombobox();
            stockgrid = stock;
        
        }

        private void InitializeCombobox()
        {
            UnitsComboBox.Items.AddRange(Enum.GetNames(typeof(Units)));
            UnitsComboBox.DataSource = Enum.GetValues(typeof(Units));
            UnitsComboBox.SelectedIndex = 0;
        }

        private void AddStockPage_Load(object sender, EventArgs e)
        {

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddStock_Click(object sender, EventArgs e)
        {
            name = NameStockTextBox.Text;
            dateOfPeremption = StockPeremptiondateTime.Value;
            quantity = int.Parse(StockQuantityBox.Text);
            units = (Units)UnitsComboBox.SelectedValue;
            bool InstanceStock  = StockControler.CheckStockCanAdd(GlobalVariable.stockList, name,dateOfPeremption);
            if(InstanceStock == true)
            {
                var stock = new Stock(name, quantity, units, dateOfPeremption);
                GlobalVariable.stockList.Add(stock);
                jsonString = JsonConvert.SerializeObject(GlobalVariable.stockList, Formatting.Indented);
                string path = Directory.GetParent(System.Environment.CurrentDirectory).Parent.Parent.FullName;
                File.WriteAllText(path + "\\Json\\Stock.json", jsonString);
                MessageBox.Show("the stock is add !!");
                MessageBox.Show("the ingredient is add !!");
                var newingredient = new Ingredient(NameStockTextBox.Text, dateOfPeremption,units);
                GlobalVariable.ingredientList.Add(newingredient);



                //stockgr
                //
                //
                //.Refresh();
                //stockgrid.DataSource = null;




            }
            else
            {
                MessageBox.Show("the name of stock is already use !! ");
            }
           

        }
    }
}
