using DigiRestoProjet.View.AddPage;
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
    public partial class UpdateCardUserControl1 : UserControl
    {
        public UpdateCardUserControl1()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSettings_Click_1(object sender, EventArgs e)
        {
            var settingpage = new SettingsPage();
            settingpage.ShowDialog();
            settingpage.Close();
            
        }

       
        private void BtnOrderInProgress_Click_1(object sender, EventArgs e)
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

        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            var AddCategoryPage = new AddCategoryPage();
            AddCategoryPage.ShowDialog();

        }

        private void BtnOrderMode_Click(object sender, EventArgs e)
        {
           
            CardUserControl1.Instance.Dock = DockStyle.Fill;    
            MainPage.mainPanel.Controls.Clear();
            MainPage.mainPanel.Controls.Add(CardUserControl1.Instance);

        }
    }
}
