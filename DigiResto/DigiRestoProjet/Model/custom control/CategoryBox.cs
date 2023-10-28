using DigiRestoProjet.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiRestoProjet.Model.custom_control
{
    public class CategoryBox : TableLayoutPanel
    {
       private static CategoryBox  _instance;
       public static CategoryBox Instance
        {
            get {
                if( _instance == null)
                {
                    _instance = new CategoryBox();
                }
                return _instance;
            }
        }

       private CategoryBox()
        {

            if (GlobalVariable.categoryList == null)
            {
                var categoryList = GlobalVariable.DeserializedCategoryJson();
               }       
            this.ColumnCount = 1;
            this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TblLayoutCategory";
            this.RowCount = GlobalVariable.categoryList.Count;
            this.Size = new System.Drawing.Size(121, 676);
            this.TabIndex = 0;
            this.Dock = DockStyle.Fill;
        }
        public void UpdateControl()
        {
            this.Controls.Clear();
            int cpt = 0;
            foreach (Category category in GlobalVariable.categoryList)
            {
                this.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100));
                Button button = new()
                {
                    Name = category.Name,
                    Text = category.Name,
                    Dock = DockStyle.Fill,
                    FlatStyle = FlatStyle.Flat
                };
                button.Click += new System.EventHandler(CardUserControl1.Instance.button1_Click);
                button.BackColor = category.BackgroundColor;
                this.Controls.Add(button, 0, cpt);
                cpt++;
            }
            // if it is the first time, add categorybox to panel2
            if (CardUserControl1.Instance.panel2.Controls.Count == 0)
                CardUserControl1.Instance.panel2.Controls.Add(this);
        }
    }
}
