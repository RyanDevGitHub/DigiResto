using DigiResto.Controller;
using DigiRestoProjet.Controller;
using DigiRestoProjet.Model;
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

namespace DigiRestoProjet.View
{
    public partial class BillDetail : Form
    {
        public BillDetail()
        {
            InitializeComponent();
            ShowBillDetail();
        }

        #region methods
         public void ShowBillDetail()
        {
            //GET ID BILL
            int BillId = BillCheckoutController.Instance.GetIdBill();
            if (BillId != -1)
            {
                Bill BillHistory = BillController.Instance.LoadCheckOutBillById(BillId);

                List<BillInfo> BillInfoList = BillInfoController.Instance.GetBillInfo();
                BillInfo billInfo = BillInfoList.Where(p => p.BillId == BillId).FirstOrDefault();

                ObservableCollection<Article> ArticleList = GlobalVariable.articleList;
                ObservableCollection<Menu> MenuList = GlobalVariable.menuList;

                lbDate.Text = BillHistory.DateCheckOut.Date.ToString();
                //lbTime.Text = BillHistory.DateCheckOut.Hour.ToString() +":"+ BillHistory.DateCheckOut.Minute.ToString();
                lbNbOrder.Text += BillId.ToString();
                lbNbTable.Text += BillHistory.TableId.ToString();
                lbTotalPrice.Text += BillHistory.Total.ToString() + " €";
                lbDateCheckin.Text += BillHistory.DateCheckIn.ToShortDateString();
                lbPayement.Text += BillHistory.PaymentMethod.ToString();
                lbServer.Text += BillHistory.Manage.ToString();

                foreach (FoodQuantity food in billInfo.Food)
                {
                    Article articleInBill = ArticleList.Where(p => p.Name == food.FoodName).FirstOrDefault();
                    Menu ArticleMenuBill = MenuList.Where(m => m.Name == food.FoodName).FirstOrDefault();

                    if (articleInBill != null)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = articleInBill.Name.ToString();
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = food.Quantity.ToString() });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = food.PriceTotal  + "€" });

                        lvBillDetail.Items.Add(item);
                    }
                    if (ArticleMenuBill != null)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = ArticleMenuBill.Name.ToString();
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = food.Quantity.ToString() });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = food.PriceTotal + "€" });

                        lvBillDetail.Items.Add(item);
                    }
                }
                BillCheckoutController.Instance.ResetBill();
            }
        }

        #endregion

        private void BillDetail_Load(object sender, EventArgs e)
        {

        }
    }
}
