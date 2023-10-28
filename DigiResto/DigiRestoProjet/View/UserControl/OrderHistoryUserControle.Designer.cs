namespace DigiRestoProjet.View
{
    public partial class OrderHistoryUserControle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderHistoryUserControle));
            BtnSettings = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnMainMenu = new Button();
            label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            lvHistory = new ListView();
            NbOrder = new ColumnHeader();
            DateCheckOut = new ColumnHeader();
            PriceOrder = new ColumnHeader();
            tableLayoutPanel5 = new TableLayoutPanel();
            Dtime = new DateTimePicker();
            BtnSearch = new Button();
            imageList1 = new ImageList(components);
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // BtnSettings
            // 
            BtnSettings.ImageIndex = 1;
            BtnSettings.ImageList = imageList1;
            BtnSettings.Location = new Point(3, 3);
            BtnSettings.Name = "BtnSettings";
            BtnSettings.Size = new Size(82, 52);
            BtnSettings.TabIndex = 5;
            BtnSettings.UseVisualStyleBackColor = true;
            BtnSettings.Click += BtnSettings_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.14883327F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 89.78278F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.553158F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 2.003081F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.306496F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 83.25709F));
            tableLayoutPanel1.Size = new Size(1243, 656);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            tableLayoutPanel1.SetColumnSpan(panel1, 3);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(1237, 7);
            panel1.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Location = new Point(74, 3);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(6, 7);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(201, 4);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(24, 62);
            panel2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84F));
            tableLayoutPanel2.Controls.Add(btnMainMenu, 0, 0);
            tableLayoutPanel2.Controls.Add(BtnSettings, 0, 0);
            tableLayoutPanel2.Controls.Add(label1, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(66, 2);
            tableLayoutPanel2.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1112, 58);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // btnMainMenu
            // 
            btnMainMenu.ImageIndex = 0;
            btnMainMenu.ImageList = imageList1;
            btnMainMenu.Location = new Point(91, 3);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(82, 52);
            btnMainMenu.TabIndex = 6;
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(178, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(932, 58);
            label1.TabIndex = 0;
            label1.Text = "History";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.0402F));
            tableLayoutPanel3.Controls.Add(lvHistory, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(66, 111);
            tableLayoutPanel3.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1112, 543);
            tableLayoutPanel3.TabIndex = 9;
            // 
            // lvHistory
            // 
            lvHistory.Columns.AddRange(new ColumnHeader[] { NbOrder, DateCheckOut, PriceOrder });
            lvHistory.Dock = DockStyle.Fill;
            lvHistory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lvHistory.FullRowSelect = true;
            lvHistory.Location = new Point(2, 2);
            lvHistory.Margin = new Padding(2, 2, 2, 2);
            lvHistory.Name = "lvHistory";
            lvHistory.Size = new Size(1108, 539);
            lvHistory.TabIndex = 0;
            lvHistory.UseCompatibleStateImageBehavior = false;
            lvHistory.View = System.Windows.Forms.View.Details;
            lvHistory.SelectedIndexChanged += lvHistory_SelectedIndexChanged;
            // 
            // NbOrder
            // 
            NbOrder.Text = "N° Order";
            NbOrder.Width = 200;
            // 
            // DateCheckOut
            // 
            DateCheckOut.Text = "Date and Time";
            DateCheckOut.Width = 400;
            // 
            // PriceOrder
            // 
            PriceOrder.Text = "Total Price";
            PriceOrder.Width = 200;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.97643F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.02357F));
            tableLayoutPanel5.Controls.Add(Dtime, 0, 0);
            tableLayoutPanel5.Controls.Add(BtnSearch, 1, 0);
            tableLayoutPanel5.Location = new Point(66, 77);
            tableLayoutPanel5.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(356, 30);
            tableLayoutPanel5.TabIndex = 10;
            // 
            // Dtime
            // 
            Dtime.CustomFormat = "dd/mm/yyyy";
            Dtime.Dock = DockStyle.Fill;
            Dtime.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Dtime.Location = new Point(2, 2);
            Dtime.Margin = new Padding(2, 2, 2, 2);
            Dtime.Name = "Dtime";
            Dtime.Size = new Size(237, 25);
            Dtime.TabIndex = 8;
            // 
            // BtnSearch
            // 
            BtnSearch.ImageIndex = 2;
            BtnSearch.ImageList = imageList1;
            BtnSearch.Location = new Point(243, 2);
            BtnSearch.Margin = new Padding(2, 2, 2, 2);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(78, 26);
            BtnSearch.TabIndex = 9;
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-effacer-240.png");
            imageList1.Images.SetKeyName(1, "icons8-paramètres-240.png");
            imageList1.Images.SetKeyName(2, "icons8-chercher-100.png");
            // 
            // OrderHistoryUserControle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 87, 122);
            Controls.Add(tableLayoutPanel1);
            Name = "OrderHistoryUserControle";
            Size = new Size(1243, 656);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Button BtnSettings;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private DateTimePicker Dtime;
        private TableLayoutPanel tableLayoutPanel3;
        private ListView lvHistory;
        private ColumnHeader NbOrder;
        private ColumnHeader DateCheckOut;
        private ColumnHeader PriceOrder;
        private TableLayoutPanel tableLayoutPanel5;
        private Button BtnSearch;
        private Button btnMainMenu;
        private ImageList imageList1;
    }
}
