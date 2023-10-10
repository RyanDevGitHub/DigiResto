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
using Xamarin.Forms;

namespace DigiRestoProjet.View
{
    public partial class AnalyseCAUserControle : UserControl
    {
        public AnalyseCAUserControle()
        {
            InitializeComponent();
            LoadChart();
            cbFilter.Items.Add("Month");
            cbFilter.Items.Add("Year");
        }
        #region methods
        private void LoadChart()
        {
            List<Revenue> revenues = ChartRevenueController.Instance.CalculeRevenue();
            var index = revenues.Count - 1;
            List<RevenueByMonth> list = revenues[index].total;

            chartRevenue.DataSource = list;
            chartRevenue.Series["Revenue"].XValueMember = "month";
            chartRevenue.Series["Revenue"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartRevenue.Series["Revenue"].YValueMembers = "revenue";
            chartRevenue.Series["Revenue"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

            //chartRevenue.Series["Revenue"].Points.AddXY("jan", 200);
            //chartRevenue.Series["Revenue"].Points.AddXY("fév", 500);
            //chartRevenue.Series["Revenue"].Points.AddXY("apr", 350);
            //chartRevenue.Series["Revenue"].Points.AddXY("may", 560);
        }

        #endregion

        #region events
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            CardUserControl1.Instance.Dock = DockStyle.Fill;
            MainPage.mainPanel.Controls.Clear();
            MainPage.mainPanel.Controls.Add(CardUserControl1.Instance);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            chartRevenue.Series.Clear();

            DateTime day = dtimeCA.Value.Date;
            double total = ChartRevenueController.Instance.getCAbyDate(day);
            chartRevenue.Series.Add("Revenue");
            chartRevenue.Series["Revenue"].Points.AddXY(day, total);
        }

        private void btSearchFilter_Click(object sender, EventArgs e)
        {
            if(cbFilter.SelectedItem.Equals("Month"))
            {
                LoadChart();
            }
            else
            {
                chartRevenue.Series.Clear();
                chartRevenue.DataSource = ChartRevenueController.Instance.CalculeRevenue();
                chartRevenue.Series.Add("Revenue");
                chartRevenue.Series["Revenue"].XValueMember = "year";
                chartRevenue.Series["Revenue"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                chartRevenue.Series["Revenue"].YValueMembers = "sum";
                chartRevenue.Series["Revenue"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

            }
        }
        #endregion

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}