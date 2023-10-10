using DigiRestoProjet.Controller;
using DigiRestoProjet.Model;
using DigiRestoProjet.View.ManagePage;
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
    public partial class OrderInProgressUserControl1 : UserControl
    {
        public OrderInProgressUserControl1()
        {
            InitializeComponent();
            LoadOrder();
        }
        #region methods

        private void LoadOrder()
        {
            lvHistorisOrder.Items.Clear();
            List<Bill> ListBill = BillController.Instance.LoadBill();
            List<BillInfo> ListBillInfo = BillInfoController.Instance.GetBillInfo();

            foreach(Bill bill in ListBill)
            {
                ListViewItem item1 = new ListViewItem();
                item1.Text = bill.Id.ToString();
                if(!bill.IsCheckOut)
                {
                    item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = " X " });
                    item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = bill.TableId.ToString() });
                    item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = bill.DateCheckIn.ToString() });
                    item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = bill.Total.ToString() });

                    lvHistorisOrder.Items.Add(item1);
                }
                
            }
        }
        #endregion

        #region events

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
           
            MainPage.mainPanel.Controls.Clear();
            MainPage.mainPanel.Controls.Add(CardUserControl1.Instance) ;
            CardUserControl1.Instance.Dock = System.Windows.Forms.DockStyle.Fill;


        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            var settingpage = new SettingsPage();
            settingpage.ShowDialog();
            settingpage.Close();

        }

        //private void lvHistorisOrder_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ListView? lv = sender as ListView;
        //    if (lv.SelectedItems.Count > 0)
        //    {
        //        ListViewItem listViewItem = lv.SelectedItems[0];

        //        int billId = Int32.Parse(listViewItem.SubItems[0].Text.ToString());
        //        string isCheckOut = listViewItem.SubItems[1].Text.ToString();
        //        int tableId = Int32.Parse(listViewItem.SubItems[2].Text.ToString());
                
        //        //ManageOrderInProgress p = new ManageOrderInProgress();
        //        //p.ShowDialog();

        //        LbOrderId.Text = "N° Order : " + billId;
        //    }
        //}

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnPayout_Click(object sender, EventArgs e)
        {
        }

        private void lvHistorisOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvHistorisOrder.SelectedItems.Count > 0)
            {
                LbOrderId.Text = "N° Order : " + lvHistorisOrder.SelectedItems[0].SubItems[0].Text;
                LbOrderId.Tag = lvHistorisOrder.SelectedItems[0].SubItems[0].Text;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvHistorisOrder.SelectedItems.Count > 0)
            {
                string orderId = null;
                if (lvHistorisOrder.SelectedItems.Count > 0)
                {                   
                    orderId = lvHistorisOrder.SelectedItems[0].SubItems[0].Text.ToString();

                    BillCheckoutController.Instance.SetBill(Int32.Parse(lvHistorisOrder.SelectedItems[0].SubItems[0].Text), Int32.Parse(lvHistorisOrder.SelectedItems[0].SubItems[2].Text));
                    this.Hide();
                    MainPage.mainPanel.Controls.Clear();
                    MainPage.mainPanel.Controls.Add(CardUserControl1.Instance);
                    CardUserControl1.ShowOrderInProgress();
                    CardUserControl1.Instance.Dock = System.Windows.Forms.DockStyle.Fill;

                }
            }
        }

        private void BtnPayout_Click_1(object sender, EventArgs e)
        {

            if (lvHistorisOrder.SelectedItems.Count > 0)
            {
                BillCheckoutController.Instance.SetBill(Int32.Parse(lvHistorisOrder.SelectedItems[0].SubItems[0].Text), Int32.Parse(lvHistorisOrder.SelectedItems[0].SubItems[2].Text));
                PayoutPage p = new PayoutPage();
                p.ShowDialog();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
#endregion