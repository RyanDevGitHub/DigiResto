namespace DigiRestoProjet.View
{
    partial class BillDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbPayement = new System.Windows.Forms.Label();
            this.lbDateCheckin = new System.Windows.Forms.Label();
            this.lbServer = new System.Windows.Forms.Label();
            this.lbNbTable = new System.Windows.Forms.Label();
            this.lbNbOrder = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.lvBillDetail = new System.Windows.Forms.ListView();
            this.Article = new System.Windows.Forms.ColumnHeader();
            this.Quantity = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.42177F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.95238F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.04762F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 448F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(758, 659);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 6);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tomato;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(752, 6);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lbDate, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbTime, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(752, 45);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDate.Location = new System.Drawing.Point(3, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(370, 45);
            this.lbDate.TabIndex = 0;
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTime.Location = new System.Drawing.Point(379, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(370, 45);
            this.lbTime.TabIndex = 1;
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lbPayement, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbDateCheckin, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbServer, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbNbTable, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbNbOrder, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 66);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(752, 129);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // lbPayement
            // 
            this.lbPayement.AutoSize = true;
            this.lbPayement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPayement.Location = new System.Drawing.Point(3, 86);
            this.lbPayement.Name = "lbPayement";
            this.lbPayement.Size = new System.Drawing.Size(370, 43);
            this.lbPayement.TabIndex = 4;
            this.lbPayement.Text = "Payement :";
            this.lbPayement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDateCheckin
            // 
            this.lbDateCheckin.AutoSize = true;
            this.lbDateCheckin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDateCheckin.Location = new System.Drawing.Point(379, 43);
            this.lbDateCheckin.Name = "lbDateCheckin";
            this.lbDateCheckin.Size = new System.Drawing.Size(370, 43);
            this.lbDateCheckin.TabIndex = 3;
            this.lbDateCheckin.Text = "Date :";
            this.lbDateCheckin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbServer
            // 
            this.lbServer.AutoSize = true;
            this.lbServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbServer.Location = new System.Drawing.Point(3, 43);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(370, 43);
            this.lbServer.TabIndex = 2;
            this.lbServer.Text = "Server :";
            this.lbServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbNbTable
            // 
            this.lbNbTable.AutoSize = true;
            this.lbNbTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNbTable.Location = new System.Drawing.Point(379, 0);
            this.lbNbTable.Name = "lbNbTable";
            this.lbNbTable.Size = new System.Drawing.Size(370, 43);
            this.lbNbTable.TabIndex = 1;
            this.lbNbTable.Text = "N° Table :";
            this.lbNbTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbNbOrder
            // 
            this.lbNbOrder.AutoSize = true;
            this.lbNbOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNbOrder.Location = new System.Drawing.Point(3, 0);
            this.lbNbOrder.Name = "lbNbOrder";
            this.lbNbOrder.Size = new System.Drawing.Size(370, 43);
            this.lbNbOrder.TabIndex = 0;
            this.lbNbOrder.Text = "N° Order : ";
            this.lbNbOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.lbTotalPrice, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lvBillDetail, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 213);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.45598F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.54402F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(752, 443);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTotalPrice.Location = new System.Drawing.Point(3, 383);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(746, 60);
            this.lbTotalPrice.TabIndex = 0;
            this.lbTotalPrice.Text = "Total :";
            this.lbTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvBillDetail
            // 
            this.lvBillDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Article,
            this.Quantity,
            this.Price});
            this.lvBillDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBillDetail.Location = new System.Drawing.Point(3, 3);
            this.lvBillDetail.Name = "lvBillDetail";
            this.lvBillDetail.Size = new System.Drawing.Size(746, 377);
            this.lvBillDetail.TabIndex = 1;
            this.lvBillDetail.UseCompatibleStateImageBehavior = false;
            this.lvBillDetail.View = System.Windows.Forms.View.Details;
            // 
            // Article
            // 
            this.Article.Text = "Article";
            this.Article.Width = 300;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 100;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 200;
            // 
            // BillDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 659);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BillDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.BillDetail_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lbDate;
        private Label lbTime;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lbPayement;
        private Label lbDateCheckin;
        private Label lbServer;
        private Label lbNbTable;
        private Label lbNbOrder;
        private TableLayoutPanel tableLayoutPanel4;
        private Label lbTotalPrice;
        private ListView lvBillDetail;
        private ColumnHeader Article;
        private ColumnHeader Quantity;
        private ColumnHeader Price;
    }
}