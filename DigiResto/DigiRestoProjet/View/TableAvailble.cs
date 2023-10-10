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

namespace DigiRestoProjet.View
{
    public partial class TableAvailble : Form
    {
        public TableAvailble()
        {
            InitializeComponent();
            LoadTable();
        }
        #region methods

        void LoadTable()
        {
            flpShowTable.Controls.Clear();
            List<Table> tables = new List<Table>();

            tables = TableController.Instance.GetTableAvailable();
            foreach (Table elm in tables)
            {
               
                if (elm.IsAvailable)
                {
                    Button button = new Button() { Width = TableController.TableWidth, Height = TableController.TableHeight };
                    button.Text = elm.Id.ToString() + Environment.NewLine + "Size : " + elm.Size.ToString();
                    button.Click += Button_Click;
                    button.Tag = elm;
                    button.BackColor = Color.LightPink;
                    flpShowTable.Controls.Add(button);
                }
                
            }

        }


        #endregion

        private void Button_Click(object? sender, EventArgs e)
        {
            int tableId = ((sender as Button).Tag as Table).Id;
            BillController.Instance.AddNewBillOnSite(tableId);
            if (TableController.Instance.SetTableNotAvailable(tableId))
            {
                DialogResult dlr = MessageBox.Show("Add Table N° " + tableId.ToString() + " success !");
                if (dlr == DialogResult.OK) this.Close();
            }
        }
    }
}
