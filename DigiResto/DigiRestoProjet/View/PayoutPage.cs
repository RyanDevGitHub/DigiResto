using DigiRestoProjet.Controller;
using DigiRestoProjet.Model;
using DigiRestoProjet.View;
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

namespace Projet_Pi_DIGIRESTO.View
{
    public partial class PayoutPage : Form
    {
        public PayoutPage()
        {
            InitializeComponent();
            LoadBill();
        }
        #region methods
        public void LoadBill()
        {
            //GET ID BILL
            int BillId = BillCheckoutController.Instance.GetIdBill();
            if (BillId != -1)
            {
                Bill BillHistory = BillController.Instance.GetNotCheckOutBillById(BillId);

                List<BillInfo> BillInfoList = BillInfoController.Instance.GetBillInfo();
                BillInfo billInfo = BillInfoList.Where(p => p.BillId == BillId).FirstOrDefault();

                lbTotal.Text = BillHistory.Total.ToString();
                ObservableCollection<Article> ArticleList = GlobalVariable.articleList;
                ObservableCollection<Menu> MenuList = GlobalVariable.menuList;

                foreach (FoodQuantity food in billInfo.Food)
                {
                    Article articleInBill = ArticleList.Where(p => p.Name == food.FoodName).FirstOrDefault();
                    Menu menuArticleInBill = MenuList.Where(m => m.Name == food.FoodName).FirstOrDefault();

                    if (articleInBill != null)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = articleInBill.Name.ToString();
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = food.Quantity.ToString() });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = food.PriceTotal.ToString() + "€" });

                        lvBillPayment.Items.Add(item);
                    }
                    if (menuArticleInBill != null)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = menuArticleInBill.Name.ToString();
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = food.Quantity.ToString() });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = food.PriceTotal.ToString() + "€" });

                        lvBillPayment.Items.Add(item);
                    }
                }
                //BillCheckoutController.Instance.ResetBill();
            }
        }

        #endregion

        private void btnNb1_Click(object sender, EventArgs e)
        {
            tbPayment.Text += "1";
        }

        private void btnBn2_Click(object sender, EventArgs e)
        {
            tbPayment.Text += "2";
        }

        private void btnBn3_Click(object sender, EventArgs e)
        {
            tbPayment.Text += "3";
        }

        private void btnBn4_Click(object sender, EventArgs e)
        {
            tbPayment.Text += "4";
        }

        private void btnNb5_Click(object sender, EventArgs e)
        {
            tbPayment.Text += "5";
        }

        private void btnNb6_Click(object sender, EventArgs e)
        {
            tbPayment.Text += "6";
        }

        private void btnNb7_Click(object sender, EventArgs e)
        {
            tbPayment.Text += "7";
        }

        private void btnNb8_Click(object sender, EventArgs e)
        {
            tbPayment.Text += "8";
        }

        private void btnNb9_Click(object sender, EventArgs e)
        {
            tbPayment.Text += "9";
        }

        private void btnNb0_Click(object sender, EventArgs e)
        {
            tbPayment.Text += "0";
        }
        private void btnPoint_Click(object sender, EventArgs e)
        {
            tbPayment.Text += ".";
        }
      
        private void btnCash_Click(object sender, EventArgs e)
        {
            float change;
            if(tbPayment.Text != "")
            {
                change = float.Parse(lbTotal.Text.ToString()) - float.Parse(tbPayment.Text.ToString());
                lbChange.Text = change.ToString();

                lbTotal.Text = change.ToString();
                lbTotal.ForeColor = Color.Red;
                tbPayment.Text = "";
                if (change == 0)
                {
                    if(BillController.Instance.SetBillCheckOut(BillCheckoutController.Instance.GetIdBill(), "Cash"))
                    {
                                             
                        int billId = BillCheckoutController.Instance.GetIdBill();
                        StockControler.UpdateStockQuantity(billId);
                        BillCheckoutController.Instance.ResetBill();
                        
                        TableController.Instance.SetTableAvailable(BillCheckoutController.Instance.GetTableBill());
                        CardUserControl1.Instance.uploadOrder();
                        MessageBox.Show("OK");
                        this.Hide();
                    }
                }
                else
                {
                    lbTotal.Text = change.ToString();
                    lbTotal.ForeColor = Color.Red;
                    tbPayment.Text = "";
                }
            }
        }

        private void btnCB_Click(object sender, EventArgs e)
        {
            float change;
            if (tbPayment.Text != "")
            {
                change = float.Parse(lbTotal.Text.ToString()) - float.Parse(tbPayment.Text.ToString());
                lbChange.Text = change.ToString();

                lbTotal.Text = change.ToString();
                lbTotal.ForeColor = Color.Red;
                tbPayment.Text = "";
                if (change == 0)
                {
                    if (BillController.Instance.SetBillCheckOut(BillCheckoutController.Instance.GetIdBill(), "CB"))
                    {
                        int billId = BillCheckoutController.Instance.GetIdBill();
                        StockControler.UpdateStockQuantity(billId);
                        BillCheckoutController.Instance.ResetBill();
                        TableController.Instance.SetTableAvailable(BillCheckoutController.Instance.GetTableBill());
                        CardUserControl1.Instance.uploadOrder();
                        MessageBox.Show("OK");
                        this.Hide();
                    }
                }
                else
                {
                    lbTotal.Text = change.ToString();
                    lbTotal.ForeColor = Color.Red;
                    tbPayment.Text = "";
                }
            }
        }

        private void btnCartResto_Click(object sender, EventArgs e)
        {
            int change;
            if (tbPayment.Text != "")
            {
                change = Int32.Parse(lbTotal.Text.ToString()) - Int32.Parse(tbPayment.Text.ToString());
                lbChange.Text = change.ToString();

                lbTotal.Text = change.ToString();
                lbTotal.ForeColor = Color.Red;
                tbPayment.Text = "";
                if (change == 0)
                {
                    if (BillController.Instance.SetBillCheckOut(BillCheckoutController.Instance.GetIdBill(), "CartResto"))
                    {
                        int billId = BillCheckoutController.Instance.GetIdBill();
                        StockControler.UpdateStockQuantity(billId);
                        BillCheckoutController.Instance.ResetBill();
                        TableController.Instance.SetTableAvailable(BillCheckoutController.Instance.GetTableBill());
                        CardUserControl1.Instance.uploadOrder();
                        MessageBox.Show("OK");
                        this.Hide();
                    }
                }
                else
                {
                    lbTotal.Text = change.ToString();
                    lbTotal.ForeColor = Color.Red;
                    tbPayment.Text = "";
                }
            }
        }

        private void btnANCV_Click(object sender, EventArgs e)
        {
            int change;
            if (tbPayment.Text != "")
            {
                change = Int32.Parse(lbTotal.Text.ToString()) - Int32.Parse(tbPayment.Text.ToString());
                lbChange.Text = change.ToString();

                lbTotal.Text = change.ToString();
                lbTotal.ForeColor = Color.Red;
                tbPayment.Text = "";
                if (change == 0)
                {
                    if (BillController.Instance.SetBillCheckOut(BillCheckoutController.Instance.GetIdBill(), "ANCV"))
                    {
                        int billId = BillCheckoutController.Instance.GetIdBill();
                        StockControler.UpdateStockQuantity(billId);
                        BillCheckoutController.Instance.ResetBill();
                        TableController.Instance.SetTableAvailable(BillCheckoutController.Instance.GetTableBill());
                        CardUserControl1.Instance.uploadOrder();
                        MessageBox.Show("OK");
                        this.Hide();
                    }
                }
                else
                {
                    lbTotal.Text = change.ToString();
                    lbTotal.ForeColor = Color.Red;
                    tbPayment.Text = "";
                }
            }
        }
        private void btn1sur1_Click(object sender, EventArgs e)
        {
            tbPayment.Text = lbTotal.Text.ToString();
        }

        private void btn1sur2_Click(object sender, EventArgs e)
        {
            tbPayment.Text = (float.Parse(lbTotal.Text.ToString()) /2).ToString();
        }

        private void btn1sur3_Click(object sender, EventArgs e)
        {
            tbPayment.Text = (float.Parse(lbTotal.Text.ToString()) / 3).ToString();
        }

        private void btn1sur4_Click(object sender, EventArgs e)
        {
            tbPayment.Text = (float.Parse(lbTotal.Text.ToString()) / 4).ToString();
        }

        private void btn1sur5_Click(object sender, EventArgs e)
        {
            tbPayment.Text = (float.Parse(lbTotal.Text.ToString()) / 5).ToString();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            tbPayment.Text += "10";
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            tbPayment.Text += "20";
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            tbPayment.Text += "50";
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            tbPayment.Text += "100";
        }
    }
}
