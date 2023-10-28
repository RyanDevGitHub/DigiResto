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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderInProgressUserControl1));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            BtnOrder = new Button();
            BtnSettings = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            BtnPayout = new Button();
            btnUpdate = new Button();
            LbOrderId = new Label();
            lvHistorisOrder = new ListView();
            NbOrder = new ColumnHeader();
            CheckOut = new ColumnHeader();
            NbTable = new ColumnHeader();
            TimeCheckIn = new ColumnHeader();
            Price = new ColumnHeader();
            imageList1 = new ImageList(components);
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(34, 87, 122);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.40397F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85.59602F));
            tableLayoutPanel1.Size = new Size(1102, 611);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BtnOrder);
            panel1.Controls.Add(BtnSettings);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1096, 82);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(366, 17);
            label1.Name = "label1";
            label1.Size = new Size(360, 38);
            label1.TabIndex = 2;
            label1.Text = "Order In Progresse";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // BtnOrder
            // 
            BtnOrder.Location = new Point(184, 15);
            BtnOrder.Name = "BtnOrder";
            BtnOrder.Size = new Size(83, 40);
            BtnOrder.TabIndex = 1;
            BtnOrder.Text = "OrderMode";
            BtnOrder.UseVisualStyleBackColor = true;
            BtnOrder.Click += BtnOrder_Click;
            // 
            // BtnSettings
            // 
            BtnSettings.ImageIndex = 1;
            BtnSettings.ImageList = imageList1;
            BtnSettings.Location = new Point(60, 15);
            BtnSettings.Name = "BtnSettings";
            BtnSettings.Size = new Size(81, 40);
            BtnSettings.TabIndex = 0;
            BtnSettings.UseVisualStyleBackColor = true;
            BtnSettings.Click += BtnSettings_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.94931F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.05069F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Controls.Add(lvHistorisOrder, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(150, 93);
            tableLayoutPanel2.Margin = new Padding(150, 5, 5, 40);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(947, 478);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(BtnPayout, 0, 2);
            tableLayoutPanel3.Controls.Add(btnUpdate, 0, 1);
            tableLayoutPanel3.Controls.Add(LbOrderId, 0, 0);
            tableLayoutPanel3.Location = new Point(797, 2);
            tableLayoutPanel3.Margin = new Padding(2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutPanel3.Size = new Size(148, 189);
            tableLayoutPanel3.TabIndex = 3;
            tableLayoutPanel3.Paint += tableLayoutPanel3_Paint;
            // 
            // BtnPayout
            // 
            BtnPayout.Dock = DockStyle.Fill;
            BtnPayout.ImageIndex = 2;
            BtnPayout.ImageList = imageList1;
            BtnPayout.Location = new Point(2, 143);
            BtnPayout.Margin = new Padding(2);
            BtnPayout.Name = "BtnPayout";
            BtnPayout.Size = new Size(144, 44);
            BtnPayout.TabIndex = 2;
            BtnPayout.Text = "Payout";
            BtnPayout.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnPayout.UseVisualStyleBackColor = true;
            BtnPayout.Click += BtnPayout_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Dock = DockStyle.Fill;
            btnUpdate.ImageIndex = 3;
            btnUpdate.ImageList = imageList1;
            btnUpdate.Location = new Point(2, 96);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(144, 43);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.TextImageRelation = TextImageRelation.ImageAboveText;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // LbOrderId
            // 
            LbOrderId.AutoSize = true;
            LbOrderId.BackColor = Color.White;
            LbOrderId.Dock = DockStyle.Fill;
            LbOrderId.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LbOrderId.Location = new Point(2, 0);
            LbOrderId.Margin = new Padding(2, 0, 2, 0);
            LbOrderId.Name = "LbOrderId";
            LbOrderId.Size = new Size(144, 94);
            LbOrderId.TabIndex = 4;
            // 
            // lvHistorisOrder
            // 
            lvHistorisOrder.Columns.AddRange(new ColumnHeader[] { NbOrder, CheckOut, NbTable, TimeCheckIn, Price });
            lvHistorisOrder.Dock = DockStyle.Fill;
            lvHistorisOrder.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lvHistorisOrder.FullRowSelect = true;
            lvHistorisOrder.Location = new Point(2, 2);
            lvHistorisOrder.Margin = new Padding(2);
            lvHistorisOrder.Name = "lvHistorisOrder";
            lvHistorisOrder.Size = new Size(791, 474);
            lvHistorisOrder.TabIndex = 2;
            lvHistorisOrder.UseCompatibleStateImageBehavior = false;
            lvHistorisOrder.View = System.Windows.Forms.View.Details;
            lvHistorisOrder.SelectedIndexChanged += lvHistorisOrder_SelectedIndexChanged;
            // 
            // NbOrder
            // 
            NbOrder.Text = "N° Order";
            NbOrder.Width = 150;
            // 
            // CheckOut
            // 
            CheckOut.Text = "CheckOut";
            CheckOut.Width = 100;
            // 
            // NbTable
            // 
            NbTable.Text = "N° Table";
            NbTable.Width = 150;
            // 
            // TimeCheckIn
            // 
            TimeCheckIn.Text = "Time";
            TimeCheckIn.Width = 300;
            // 
            // Price
            // 
            Price.Text = "Total Price";
            Price.Width = 300;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-effacer-240.png");
            imageList1.Images.SetKeyName(1, "icons8-paramètres-240.png");
            imageList1.Images.SetKeyName(2, "icons8-euro-100.png");
            imageList1.Images.SetKeyName(3, "icons8-modifier-100.png");
            // 
            // OrderInProgressUserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "OrderInProgressUserControl1";
            Size = new Size(1102, 611);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
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
        private ImageList imageList1;
    }
}
