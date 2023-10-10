using DigiRestoProjet;
using DigiRestoProjet.View;
using DigiRestoProjet.View.AddPage;
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
    public partial class SettingsPage : Form
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void SettingsPage_Load(object sender, EventArgs e)
        {

        }

        private void BtnSettingUser_Click(object sender, EventArgs e)
        {
            var manageUserPageForm = new ManageUserPage();
            manageUserPageForm.ShowDialog();
            
        }

        private void BtnSettingCard_Click(object sender, EventArgs e)
        {
            var UpdatecardControl = new UpdateCardUserControl1();
            UpdatecardControl.Dock = DockStyle.Fill;
            this.Close();
            MainPage.mainPanel.Controls.Clear();
            MainPage.mainPanel.Controls.Add(UpdatecardControl);
        }

        private void BtnSettingsCategory_Click(object sender, EventArgs e)
        {
            var manageArticlePage = new ManageCategoryPage();
            manageArticlePage.ShowDialog();
        }

        private void BtnSettingTable_Click(object sender, EventArgs e)
        {

            var manageTablePage = new ManageTablePage();
            manageTablePage.ShowDialog();
        }

        private void BtnStockSettings_Click(object sender, EventArgs e)
        {
            this.Close();
            var stockusercontrol = new StockUserControl();
            stockusercontrol.Dock = DockStyle.Fill;
            MainPage.mainPanel.Controls.Clear();
            MainPage.mainPanel.Controls.Add(stockusercontrol);
            
        }

        private void BtnSettingComptability_Click(object sender, EventArgs e)
        {
            this.Close();
            var settingComptability = new SettingComptability();
            settingComptability.ShowDialog();
        }

        private void BtnSettingMenu_Click(object sender, EventArgs e)
        {
            var manageMenu =  new ManageMenu();
            manageMenu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnArticle_Click(object sender, EventArgs e)
        {
            var manageArticlePage = new ManageArticlePage();
            manageArticlePage.ShowDialog();

        }
    }
}
