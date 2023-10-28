using DigiRestoProjet.Controller;
using DigiRestoProjet.Model;
using DigiRestoProjet.View.ManagePage;
using Projet_Pi_DIGIRESTO.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiRestoProjet.View
{
    public partial class CardUserControl1 : UserControl
    {
        private static CardUserControl1 _instance;
        public static CardUserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CardUserControl1();
                }
                return _instance;
            }
        }
        public Menu menu;
        private CardUserControl1()
        {
            InitializeComponent();
            //ShowOrderInProgress();
            _instance = this;
            ControllerCardUserControl.UpdateCatInControlUser();
            GlobalVariable.categoryList.CollectionChanged += CategoryList_CollectionChanged;
            GlobalVariable.articleList.CollectionChanged += ArticleList_CollectionChanged;
        }

        private void ArticleList_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    if (GlobalVariable.categoryList.Count > 0)
                    {
                        ControllerCardUserControl.DisplayArticleMenu(GlobalVariable.categoryList[0], this.TblDisplayArticle, this);
                    }

                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    for (var i = 0; i < e.OldItems.Count; i++)
                    {
                        ControllerCardUserControl.deleteArticleinCategory((Article)e.OldItems[i]);
                    }
                    if (GlobalVariable.categoryList.Count > 0)
                    {
                        ControllerCardUserControl.DisplayArticleMenu(GlobalVariable.categoryList[0], this.TblDisplayArticle, this);
                    }
                    break;
            }
        }

        private void CategoryList_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    ControllerCardUserControl.UpdateCatInControlUser();
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    ControllerCardUserControl.UpdateCatInControlUser();
                    break;
            }
        }

        public void RefreshList()
        {

        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            var settingpage = new SettingsPage();
            settingpage.ShowDialog();
            settingpage.Close();

        }

        public void uploadOrder()
        {
            OrderInProgressUserControl1 orderinprogressControl = new OrderInProgressUserControl1();
            MainPage.mainPanel.Controls.Clear();
            MainPage.mainPanel.Controls.Add(orderinprogressControl);
            orderinprogressControl.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void BtnOrderInProgress_Click(object sender, EventArgs e)
        {
            OrderInProgressUserControl1 orderinprogressControl = new OrderInProgressUserControl1();
            MainPage.mainPanel.Controls.Clear();
            MainPage.mainPanel.Controls.Add(orderinprogressControl);
            orderinprogressControl.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public static void ShowOrderInProgress()
        {
            Instance.lvBill.Items.Clear();
            int BillId = BillCheckoutController.Instance.GetIdBill();
            if (BillId != -1)
            {
                List<BillInfo> BillInfoList = BillInfoController.Instance.GetBillInfo();
                BillInfo billInfo = BillInfoList.Where(p => p.BillId == BillId).FirstOrDefault();

                ObservableCollection<Article> ArticleList = GlobalVariable.articleList;
                ObservableCollection<Menu> MenuList = GlobalVariable.menuList;

                if (billInfo != null)
                {
                    foreach (FoodQuantity food in billInfo.Food)
                    {
                        Article item = ArticleList.Where(p => p.Name == food.FoodName).FirstOrDefault();
                        Menu menuItem = MenuList.Where(y => y.Name == food.FoodName).FirstOrDefault();

                        if (item != null)
                        {
                            ListViewItem item1 = new ListViewItem();
                            item1.Text = 0.ToString();
                            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = food.FoodName.ToString() });
                            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = food.Quantity.ToString() });
                            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = food.PriceTotal.ToString() });

                            Instance.lvBill.Items.Add(item1);
                        }
                        if (menuItem != null)
                        {
                            ListViewItem item1 = new ListViewItem();
                            item1.Text = 0.ToString();
                            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = food.FoodName.ToString() });
                            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = food.Quantity.ToString() });
                            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = food.PriceTotal.ToString() });

                            Instance.lvBill.Items.Add(item1);
                        }
                    }

                }
            }
        }

        private void AddItemInBill(String Name, double Price)
        {
            bool IsExist = false;
            //CHECK ITEM IS EXIST 
            for (int i = 0; i < lvBill.Items.Count; i++)
            {
                if (lvBill.Items[i].SubItems[1].Text.ToString() == Name)
                {
                    int quantity;
                    double price1;

                    double price = double.Parse(lvBill.Items[i].SubItems[3].Text.ToString());
                    price1 = price / Convert.ToInt32(lvBill.Items[i].SubItems[2].Text);

                    quantity = Convert.ToInt32(lvBill.Items[i].SubItems[2].Text) + 1;
                    lvBill.Items[i].SubItems[2].Text = quantity.ToString();
                    lvBill.Items[i].SubItems[3].Text = (price1 * quantity).ToString();

                    IsExist = true;
                }
            }

            //ADD NEW ITEM TO LISTVIEW

            if (!IsExist)
            {
                ListViewItem item1 = new ListViewItem();
                item1.Text = 0.ToString();
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = Name });
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "1" });
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = Price.ToString() });

                lvBill.Items.Add(item1);
            }
        }
        private void BtnSaveOrder_Click(object sender, EventArgs e)
        {
            List<FoodQuantity> quantityList = new List<FoodQuantity>();
            float TotalPriceBill = 0;
            foreach (ListViewItem item in lvBill.Items)
            {

                // GET FOOD INFO BY FOOD NAME

                // ADD NEW FOODQUANTITY LIST
                FoodQuantity foodCount = new FoodQuantity();

                foodCount.FoodName = item.SubItems[1].Text.ToString();
                foodCount.Quantity = Int32.Parse(item.SubItems[2].Text.ToString());
                foodCount.PriceTotal = float.Parse(item.SubItems[3].Text.ToString());

                TotalPriceBill += foodCount.PriceTotal;
                quantityList.Add(foodCount);

            }
            // CHECK BILL IS ON SITE

            // IF ON SITE => GET TABLE ID

            // ADD NEW BILL WITH TABLE ID
            int billId;
            int BillUpdateId = BillCheckoutController.Instance.GetIdBill();
            if (BillUpdateId != -1)
            {
                billId = BillUpdateId;
                BillController.Instance.UpdateTotalPrice(TotalPriceBill, billId);
                BillInfoController.Instance.UpdateBillInfo(billId, FoodQuantityController.Instance.AddNewFoodQuantity(quantityList));
            }
            else
            {
                billId = BillController.Instance.GetBillId();
                BillController.Instance.AddTotalPrice(TotalPriceBill);

                // ADD FOODQUANTITY TO BILLINFO
                BillInfoController.Instance.AddNewBillInfo(billId, FoodQuantityController.Instance.AddNewFoodQuantity(quantityList));
                BillInfoController.Instance.AddArticleMenuInBill(billId, ArticleMenuController.Instance.LoadArticleMenu());
                ArticleMenuController.Instance.SetArticleMenu();
                // ADD NEW BILLINFO
            }
            //StockControler.UpdateStockQuantity(billId);
            MessageBox.Show("You have successfully saved this order !", "Message",
               MessageBoxButtons.OK, MessageBoxIcon.Information);

            BillCheckoutController.Instance.ResetBill();
        }

        private void lvBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView? lv = sender as ListView;
            if (lv.SelectedItems.Count > 0)
            {
                ListViewItem listViewItem = lv.SelectedItems[0];

                // int articleId = Int32.Parse(listViewItem.SubItems[0].Text.ToString());
                string articleName = listViewItem.SubItems[1].Text.ToString();
                int quantity = Int32.Parse(listViewItem.SubItems[2].Text.ToString());
                float total = float.Parse(listViewItem.SubItems[3].Text.ToString());
                if (ArticleInCommandController.Instance.AddArticle(/*articleId,*/ articleName, quantity, total))
                {
                    ManageArticleInCommand m = new ManageArticleInCommand();
                    m.ShowDialog();
                    ArticleInCommand article = ArticleInCommandController.Instance.LoadArticle();
                    if (article.Quantity > 0)
                    {
                        listViewItem.SubItems[2].Text = article.Quantity.ToString();
                        listViewItem.SubItems[3].Text = article.Price.ToString();
                    }
                    else
                    {
                        lv.Items.RemoveAt(listViewItem.Index);
                    }

                }
            }
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void CardUserControl1_Load(object sender, EventArgs e)
        {
            //ControllerCardUserControl.DisplayArticleMenu(GlobalVariable.categoryList[0].ArticleList, TlpArticleMenu, this);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            var buttonclicked = (Button)sender;
            Category catclicked = GlobalVariable.categoryList.FirstOrDefault(x => x.Name == buttonclicked.Name);
            ControllerCardUserControl.DisplayArticleMenu(catclicked, this.TblDisplayArticle, this);
        }

        public void buttonMenu_Click(object sender, EventArgs e)
        {
            foreach (Menu me in GlobalVariable.menuList)
            {
                if (me.Name == (sender as Button).Text)
                {
                    menu = me;
                    AddItemInBill((sender as Button).Tag.ToString(), menu.Price);
                }
            }
            var menupage = new MenuPage(menu.Name, menu.DishArticle, menu.EnterArticle, menu.DessertArticle);
            menupage.Show();
        }
        public void buttonArticle_Click(object sender, EventArgs e)
        {
            var articleName = ((sender as Button).Tag).ToString();
            Article item = ArticleController.Instance.GetArticleByName(articleName);
            AddItemInBill(item.Name, item.Price);


        }
        private void BtnTakeAway_Click(object sender, EventArgs e)
        {
            List<FoodQuantity> quantityList = new List<FoodQuantity>();
            float TotalPriceBill = 0;
            foreach (ListViewItem item in lvBill.Items)
            {

                // GET FOOD INFO BY FOOD NAME

                // ADD NEW FOODQUANTITY LIST
                FoodQuantity foodCount = new FoodQuantity();

                foodCount.FoodName = item.SubItems[1].Text.ToString();
                foodCount.Quantity = Int32.Parse(item.SubItems[2].Text.ToString());
                foodCount.PriceTotal = float.Parse(item.SubItems[3].Text.ToString());

                TotalPriceBill += foodCount.PriceTotal;
                quantityList.Add(foodCount);

            }
            // ADD NEW BILL
            int billId;
            BillController.Instance.AddNewBillTakeAway(TotalPriceBill);
            billId = BillController.Instance.GetBillId();


            // ADD FOODQUANTITY TO BILLINFO
            BillInfoController.Instance.AddNewBillInfo(billId, FoodQuantityController.Instance.AddNewFoodQuantity(quantityList));
            BillCheckoutController.Instance.SetBill(billId, 0);

            PayoutPage p = new PayoutPage();
            p.ShowDialog();
        }

        private void BtnOnSite_Click(object sender, EventArgs e)
        {
            TableAvailble p = new TableAvailble();
            p.ShowDialog();
        }
        private void btnResetCommand_Click(object sender, EventArgs e)
        {
            BillCheckoutController.Instance.ResetBill();
            lvBill.Items.Clear();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
