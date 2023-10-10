using DigiRestoProjet.Controller;
using DigiRestoProjet.Model;
using Projet_Pi_DIGIRESTO.View;
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
    public partial class OrderHistoryUserControle : UserControl
    {
        public OrderHistoryUserControle()
        {
            InitializeComponent();
            LoadHistory();
        }
        #region methods

        public void LoadHistory()
        {
            List<Bill> ListBill = BillController.Instance.LoadCheckOutBill();
            foreach(Bill bill in ListBill)
            {
                ListViewItem item = new ListViewItem();
                item.Text = bill.Id.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = bill.DateCheckOut.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = bill.Total.ToString() });
                lvHistory.Items.Add(item);
            }
        }
        public void LoadHistoryByDate(DateTime searchDate)
        {
            List<Bill> ListBill = BillController.Instance.LoadCheckOutBillByDate(searchDate);
            lvHistory.Items.Clear();
            foreach(Bill bill in ListBill)
            {
                ListViewItem item = new ListViewItem();
                item.Text = bill.Id.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = bill.DateCheckOut.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = bill.Total.ToString() });
                lvHistory.Items.Add(item);
            }
        }

        #endregion

        #region event
        private void BtnSettings_Click(object sender, EventArgs e)
        {
            var settingpage = new SettingsPage();
            settingpage.ShowDialog();
            settingpage.Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            DateTime SearchDate = Dtime.Value;
            LoadHistoryByDate(SearchDate);
        }

        #endregion

        private void lvHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int OrderId; 
            if(lvHistory.SelectedItems.Count > 0)
            {
                OrderId = Int32.Parse(lvHistory.SelectedItems[0].SubItems[0].Text.ToString());
                BillCheckoutController.Instance.SetBill(OrderId, 0);

                BillDetail p = new BillDetail();
                p.ShowDialog();
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage.mainPanel.Controls.Clear();
            MainPage.mainPanel.Controls.Add(CardUserControl1.Instance);
            CardUserControl1.Instance.Dock = System.Windows.Forms.DockStyle.Fill;
        }
    }
}
