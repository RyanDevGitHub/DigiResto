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
    public partial class SettingComptability : Form
    {
        public SettingComptability()
        {
            InitializeComponent();
        }

        private void SettingComptability_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
           this.Close();
           var orderHistoryUserControle =  new OrderHistoryUserControle();
           orderHistoryUserControle.Dock = DockStyle.Fill;  
           MainPage.mainPanel.Controls.Clear();
           MainPage.mainPanel.Controls.Add(orderHistoryUserControle); 
            
        }

        private void BtnStatCa_Click(object sender, EventArgs e)
        {
            this.Close();
            var analyseCAUserControl = new AnalyseCAUserControle();
            MainPage.mainPanel.Controls.Clear();
            analyseCAUserControl.Dock = DockStyle.Fill;
            MainPage.mainPanel.Controls.Add(analyseCAUserControl);
            

        }

        private void BtnStatArticle_Click(object sender, EventArgs e)
        {
            this.Close();
            var statistiqueArticleUserControl = new StatistiqueArticleUserControle();
            MainPage.mainPanel.Controls.Clear();
            statistiqueArticleUserControl.Dock= DockStyle.Fill; 
            MainPage.mainPanel.Controls.Add(statistiqueArticleUserControl);
            
        }
    }
}
