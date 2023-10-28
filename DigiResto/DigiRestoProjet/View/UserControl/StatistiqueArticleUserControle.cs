using DigiRestoProjet.Controller;
using DigiRestoProjet.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DigiRestoProjet.View
{
    public partial class StatistiqueArticleUserControle : UserControl
    {
        public StatistiqueArticleUserControle()
        {
            InitializeComponent();
            LoadChart();

            var months = System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames;
            cbFilterMonth.DataSource = months;
        }

        public void LoadChart()
        {

        }
        #region events
        private void btnSearchMonth_Click(object sender, EventArgs e)
        {
            int month = 0;

            switch (cbFilterMonth.SelectedItem.ToString())
            {
                case "January":
                    month = 1;
                    break;
                case "February":
                    month = 2;
                    break;
                case "March":
                    month = 3;
                    break;
                case "April":
                    month = 4;
                    break;
                case "May":
                    month = 5;
                    break;
                case "June":
                    month = 6;
                    break;
                case "July":
                    month = 7;
                    break;
                case "August":
                    month = 8;
                    break;
                case "September":
                    month = 9;
                    break;
                case "October":
                    month = 10;
                    break;
                case "November":
                    month = 11;
                    break;
                case "December":
                    month = 12;
                    break;
                default:
                    // code block
                    break;
            }
            IDictionary<string, int> dic = QuantitySoldController.Instance.UpdateQuantitySoldByMonth(month);
            List<FoodSold> foodSolds = new List<FoodSold>();

            foreach (var elm in dic)
            {
                FoodSold foodSold = new FoodSold();
                foodSold.FoodName = elm.Key;
                foodSold.Quantity = elm.Value;
                foodSolds.Add(foodSold);
            }

            chartSold.DataSource = foodSolds;

            chartSold.Series["Article"].XValueMember = "FoodName";
            chartSold.Series["Article"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartSold.Series["Article"].YValueMembers = "Quantity";
            chartSold.Series["Article"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            CardUserControl1.Instance.Dock = DockStyle.Fill;
            MainPage.mainPanel.Controls.Clear();
            MainPage.mainPanel.Controls.Add(CardUserControl1.Instance);
        }
        #endregion


    }
}
