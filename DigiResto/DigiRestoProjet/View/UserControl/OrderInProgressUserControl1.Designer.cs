namespace DigiRestoProjet.View
{
    partial class OrderInProgressUserControl1
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnPayout = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.LbOrderId = new System.Windows.Forms.Label();
            this.lvHistorisOrder = new System.Windows.Forms.ListView();
            this.NbOrder = new System.Windows.Forms.ColumnHeader();
            this.CheckOut = new System.Windows.Forms.ColumnHeader();
            this.NbTable = new System.Windows.Forms.ColumnHeader();
            this.TimeCheckIn = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.40397F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.59602F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1102, 611);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnOrder);
            this.panel1.Controls.Add(this.BtnSettings);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 82);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(488, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order In Progresse";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnOrder
            // 
            this.BtnOrder.Location = new System.Drawing.Point(184, 15);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(83, 40);
            this.BtnOrder.TabIndex = 1;
            this.BtnOrder.Text = "OrderMode";
            this.BtnOrder.UseVisualStyleBackColor = true;
            this.BtnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.Location = new System.Drawing.Point(60, 15);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(81, 40);
            this.BtnSettings.TabIndex = 0;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.94931F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.05069F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lvHistorisOrder, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(150, 93);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(150, 5, 5, 40);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(947, 478);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.BtnPayout, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnUpdate, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.LbOrderId, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(797, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(148, 189);
            this.tableLayoutPanel3.TabIndex = 3;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // BtnPayout
            // 
            this.BtnPayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnPayout.Location = new System.Drawing.Point(2, 143);
            this.BtnPayout.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPayout.Name = "BtnPayout";
            this.BtnPayout.Size = new System.Drawing.Size(144, 44);
            this.BtnPayout.TabIndex = 2;
            this.BtnPayout.Text = "Payout";
            this.BtnPayout.UseVisualStyleBackColor = true;
            this.BtnPayout.Click += new System.EventHandler(this.BtnPayout_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.Location = new System.Drawing.Point(2, 96);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 43);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // LbOrderId
            // 
            this.LbOrderId.AutoSize = true;
            this.LbOrderId.BackColor = System.Drawing.Color.White;
            this.LbOrderId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbOrderId.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbOrderId.Location = new System.Drawing.Point(2, 0);
            this.LbOrderId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbOrderId.Name = "LbOrderId";
            this.LbOrderId.Size = new System.Drawing.Size(144, 94);
            this.LbOrderId.TabIndex = 4;
            // 
            // lvHistorisOrder
            // 
            this.lvHistorisOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NbOrder,
            this.CheckOut,
            this.NbTable,
            this.TimeCheckIn,
            this.Price});
            this.lvHistorisOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvHistorisOrder.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvHistorisOrder.FullRowSelect = true;
            this.lvHistorisOrder.Location = new System.Drawing.Point(2, 2);
            this.lvHistorisOrder.Margin = new System.Windows.Forms.Padding(2);
            this.lvHistorisOrder.Name = "lvHistorisOrder";
            this.lvHistorisOrder.Size = new System.Drawing.Size(791, 474);
            this.lvHistorisOrder.TabIndex = 2;
            this.lvHistorisOrder.UseCompatibleStateImageBehavior = false;
            this.lvHistorisOrder.View = System.Windows.Forms.View.Details;
            this.lvHistorisOrder.SelectedIndexChanged += new System.EventHandler(this.lvHistorisOrder_SelectedIndexChanged);
            // 
            // NbOrder
            // 
            this.NbOrder.Text = "N° Order";
            this.NbOrder.Width = 150;
            // 
            // CheckOut
            // 
            this.CheckOut.Text = "CheckOut";
            this.CheckOut.Width = 100;
            // 
            // NbTable
            // 
            this.NbTable.Text = "N° Table";
            this.NbTable.Width = 150;
            // 
            // TimeCheckIn
            // 
            this.TimeCheckIn.Text = "Time";
            this.TimeCheckIn.Width = 300;
            // 
            // Price
            // 
            this.Price.Text = "Total Price";
            this.Price.Width = 300;
            // 
            // OrderInProgressUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OrderInProgressUserControl1";
            this.Size = new System.Drawing.Size(1102, 611);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button BtnOrder;
        private Button BtnSettings;
        private TableLayoutPanel tableLayoutPanel2;
        private ListView lvHistorisOrder;
        private ColumnHeader NbOrder;
        private ColumnHeader CheckOut;
        private ColumnHeader NbTable;
        private ColumnHeader TimeCheckIn;
        private ColumnHeader Price;
        private TableLayoutPanel tableLayoutPanel3;
        private Button BtnPayout;
        private Button btnUpdate;
        private Label LbOrderId;
        private Label label1;
    }
}
