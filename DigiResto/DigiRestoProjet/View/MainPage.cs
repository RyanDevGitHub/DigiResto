using DigiRestoProjet.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiRestoProjet.View
{
    public partial class MainPage : Form
    {
        //property
        private UserControl _displayUserControl;
        public UserControl DisplayUserControl
        {
            get { return _displayUserControl; }
            set { _displayUserControl = value; }
        }


       
        public MainPage()
        {
            InitializeComponent();

            InitializePageComponent();
        }

        private void InitializePageComponent()
        {
            CardUserControl1.Instance.Dock = DockStyle.Fill;
            CardUserControl1.Instance.Name = "cardUserControl";
            DisplayUserControl = CardUserControl1.Instance;
            mainPanel.Controls.Add(DisplayUserControl);
            CardUserControl1.ShowOrderInProgress();

            var p = new ConnexionPage();
            p.ShowDialog();
        }

        private void orderInProgressUserControl11_Load(object sender, EventArgs e)
        {

        }

        private void stockUserControl1_Load(object sender, EventArgs e)
        {


        }
        private void MainPage_Leave(object sender, EventArgs e)
        {


        }

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVariable.SerializeStockJson();
            GlobalVariable.ExportStockJson();
            GlobalVariable.SerializeCategoryJson();
            GlobalVariable.ExportCategoryJson();
            GlobalVariable.SerializeIngredientJson();
            GlobalVariable.ExportIngredientJson();
            GlobalVariable.SerializeArticleJson();
            GlobalVariable.ExportArticleJson();
            GlobalVariable.SerializeTableJson();
            GlobalVariable.ExportTableJson();
            GlobalVariable.SerializeIdCounterJson();
            GlobalVariable.ExportIdCounterJson();
            GlobalVariable.SerializeMenuJson();
            GlobalVariable.ExportMenuJson();
        }
    }
}
