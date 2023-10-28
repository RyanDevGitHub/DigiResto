namespace DigiRestoProjet.View
{
    partial class UpdateCardUserControl1 : UserControl
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


        #region 

        #endregion
        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ListViewItem listViewItem1 = new ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCardUserControl1));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            BtnSettings = new Button();
            BtnOrderInProgress = new Button();
            BtnOrderMode = new Button();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            BtnCategory1 = new Button();
            BtnCategory2 = new Button();
            BtnAddCategory = new Button();
            panel3 = new Panel();
            listView1 = new ListView();
            NumberOfItem = new ColumnHeader();
            NameOfItem = new ColumnHeader();
            PriceOfItem = new ColumnHeader();
            panel4 = new Panel();
            panel9 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            BtnNum0 = new Button();
            BtnNum1 = new Button();
            BtnNum2 = new Button();
            BtnNum3 = new Button();
            BtnNum4 = new Button();
            BtnNum5 = new Button();
            BtnNum6 = new Button();
            BtnNum7 = new Button();
            BtnNum8 = new Button();
            BtnNum9 = new Button();
            panel10 = new Panel();
            BtnSaveOrder = new Button();
            BtnTakeAway = new Button();
            BtnOnSite = new Button();
            imageList1 = new ImageList(components);
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            panel9.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.760001F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.48F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.76F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 2, 0);
            tableLayoutPanel1.Controls.Add(panel4, 1, 1);
            tableLayoutPanel1.Controls.Add(panel9, 2, 2);
            tableLayoutPanel1.Controls.Add(panel10, 2, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.922271F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 38.12822F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 27.47475F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 27.47475F));
            tableLayoutPanel1.Size = new Size(1230, 649);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tableLayoutPanel5);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(120, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(719, 44);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = Color.FromArgb(34, 87, 122);
            tableLayoutPanel5.ColumnCount = 8;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.Controls.Add(BtnSettings, 0, 0);
            tableLayoutPanel5.Controls.Add(BtnOrderInProgress, 1, 0);
            tableLayoutPanel5.Controls.Add(BtnOrderMode, 2, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 32.43243F));
            tableLayoutPanel5.Size = new Size(719, 44);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // BtnSettings
            // 
            BtnSettings.Dock = DockStyle.Fill;
            BtnSettings.ImageIndex = 0;
            BtnSettings.ImageList = imageList1;
            BtnSettings.Location = new Point(3, 3);
            BtnSettings.Name = "BtnSettings";
            BtnSettings.Size = new Size(83, 38);
            BtnSettings.TabIndex = 0;
            BtnSettings.UseVisualStyleBackColor = true;
            BtnSettings.Click += BtnSettings_Click_1;
            // 
            // BtnOrderInProgress
            // 
            BtnOrderInProgress.Dock = DockStyle.Fill;
            BtnOrderInProgress.Location = new Point(92, 3);
            BtnOrderInProgress.Name = "BtnOrderInProgress";
            BtnOrderInProgress.Size = new Size(83, 38);
            BtnOrderInProgress.TabIndex = 1;
            BtnOrderInProgress.Text = "OrderInProgress";
            BtnOrderInProgress.UseVisualStyleBackColor = true;
            BtnOrderInProgress.Click += BtnOrderInProgress_Click_1;
            // 
            // BtnOrderMode
            // 
            BtnOrderMode.Dock = DockStyle.Fill;
            BtnOrderMode.Location = new Point(181, 3);
            BtnOrderMode.Name = "BtnOrderMode";
            BtnOrderMode.Size = new Size(83, 38);
            BtnOrderMode.TabIndex = 2;
            BtnOrderMode.Text = "Order Mode";
            BtnOrderMode.UseVisualStyleBackColor = true;
            BtnOrderMode.Click += BtnOrderMode_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 165, 82);
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            tableLayoutPanel1.SetRowSpan(panel2, 4);
            panel2.Size = new Size(120, 649);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(BtnCategory1, 0, 0);
            tableLayoutPanel2.Controls.Add(BtnCategory2, 0, 1);
            tableLayoutPanel2.Controls.Add(BtnAddCategory, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.Size = new Size(120, 649);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // BtnCategory1
            // 
            BtnCategory1.Dock = DockStyle.Fill;
            BtnCategory1.FlatAppearance.BorderColor = Color.Black;
            BtnCategory1.FlatAppearance.BorderSize = 2;
            BtnCategory1.FlatStyle = FlatStyle.Flat;
            BtnCategory1.Location = new Point(0, 0);
            BtnCategory1.Margin = new Padding(0);
            BtnCategory1.Name = "BtnCategory1";
            BtnCategory1.Size = new Size(120, 216);
            BtnCategory1.TabIndex = 0;
            BtnCategory1.Text = "category 1";
            BtnCategory1.UseVisualStyleBackColor = true;
            // 
            // BtnCategory2
            // 
            BtnCategory2.BackColor = Color.FromArgb(128, 237, 153);
            BtnCategory2.Dock = DockStyle.Fill;
            BtnCategory2.FlatStyle = FlatStyle.Flat;
            BtnCategory2.ForeColor = Color.Black;
            BtnCategory2.Location = new Point(0, 216);
            BtnCategory2.Margin = new Padding(0);
            BtnCategory2.Name = "BtnCategory2";
            BtnCategory2.Size = new Size(120, 216);
            BtnCategory2.TabIndex = 1;
            BtnCategory2.Text = "category2";
            BtnCategory2.UseVisualStyleBackColor = false;
            // 
            // BtnAddCategory
            // 
            BtnAddCategory.BackColor = Color.FromArgb(212, 228, 188);
            BtnAddCategory.Dock = DockStyle.Fill;
            BtnAddCategory.Location = new Point(0, 432);
            BtnAddCategory.Margin = new Padding(0);
            BtnAddCategory.Name = "BtnAddCategory";
            BtnAddCategory.Size = new Size(120, 217);
            BtnAddCategory.TabIndex = 2;
            BtnAddCategory.Text = "Add Category";
            BtnAddCategory.UseVisualStyleBackColor = false;
            BtnAddCategory.Click += BtnAddCategory_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(listView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(839, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            tableLayoutPanel1.SetRowSpan(panel3, 2);
            panel3.Size = new Size(391, 291);
            panel3.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { NumberOfItem, NameOfItem, PriceOfItem });
            listView1.Dock = DockStyle.Fill;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(0, 0);
            listView1.Margin = new Padding(0);
            listView1.Name = "listView1";
            listView1.Size = new Size(391, 291);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // NumberOfItem
            // 
            NumberOfItem.Text = "Number of Item";
            // 
            // NameOfItem
            // 
            NameOfItem.Text = "NameOfItem";
            // 
            // PriceOfItem
            // 
            PriceOfItem.Text = "Price";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(34, 87, 122);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(120, 44);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            tableLayoutPanel1.SetRowSpan(panel4, 3);
            panel4.Size = new Size(719, 605);
            panel4.TabIndex = 3;
            panel4.Paint += panel4_Paint;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(34, 87, 122);
            panel9.Controls.Add(tableLayoutPanel4);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(839, 291);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Size = new Size(391, 178);
            panel9.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel4.Controls.Add(BtnNum0, 1, 3);
            tableLayoutPanel4.Controls.Add(BtnNum1, 0, 0);
            tableLayoutPanel4.Controls.Add(BtnNum2, 1, 0);
            tableLayoutPanel4.Controls.Add(BtnNum3, 2, 0);
            tableLayoutPanel4.Controls.Add(BtnNum4, 0, 1);
            tableLayoutPanel4.Controls.Add(BtnNum5, 1, 1);
            tableLayoutPanel4.Controls.Add(BtnNum6, 2, 1);
            tableLayoutPanel4.Controls.Add(BtnNum7, 0, 2);
            tableLayoutPanel4.Controls.Add(BtnNum8, 1, 2);
            tableLayoutPanel4.Controls.Add(BtnNum9, 2, 2);
            tableLayoutPanel4.Location = new Point(22, 14);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Size = new Size(394, 179);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // BtnNum0
            // 
            BtnNum0.Dock = DockStyle.Fill;
            BtnNum0.Location = new Point(134, 135);
            BtnNum0.Name = "BtnNum0";
            BtnNum0.Size = new Size(125, 41);
            BtnNum0.TabIndex = 0;
            BtnNum0.Text = "0";
            BtnNum0.UseVisualStyleBackColor = true;
            // 
            // BtnNum1
            // 
            BtnNum1.Dock = DockStyle.Fill;
            BtnNum1.Location = new Point(3, 3);
            BtnNum1.Name = "BtnNum1";
            BtnNum1.Size = new Size(125, 38);
            BtnNum1.TabIndex = 0;
            BtnNum1.Text = "1";
            BtnNum1.UseVisualStyleBackColor = true;
            // 
            // BtnNum2
            // 
            BtnNum2.Dock = DockStyle.Fill;
            BtnNum2.Location = new Point(134, 3);
            BtnNum2.Name = "BtnNum2";
            BtnNum2.Size = new Size(125, 38);
            BtnNum2.TabIndex = 1;
            BtnNum2.Text = "2";
            BtnNum2.UseVisualStyleBackColor = true;
            // 
            // BtnNum3
            // 
            BtnNum3.Dock = DockStyle.Fill;
            BtnNum3.Location = new Point(265, 3);
            BtnNum3.Name = "BtnNum3";
            BtnNum3.Size = new Size(126, 38);
            BtnNum3.TabIndex = 2;
            BtnNum3.Text = "3";
            BtnNum3.UseVisualStyleBackColor = true;
            // 
            // BtnNum4
            // 
            BtnNum4.Dock = DockStyle.Fill;
            BtnNum4.Location = new Point(3, 47);
            BtnNum4.Name = "BtnNum4";
            BtnNum4.Size = new Size(125, 38);
            BtnNum4.TabIndex = 3;
            BtnNum4.Text = "4";
            BtnNum4.UseVisualStyleBackColor = true;
            // 
            // BtnNum5
            // 
            BtnNum5.Dock = DockStyle.Fill;
            BtnNum5.Location = new Point(134, 47);
            BtnNum5.Name = "BtnNum5";
            BtnNum5.Size = new Size(125, 38);
            BtnNum5.TabIndex = 4;
            BtnNum5.Text = "5";
            BtnNum5.UseVisualStyleBackColor = true;
            // 
            // BtnNum6
            // 
            BtnNum6.Dock = DockStyle.Fill;
            BtnNum6.Location = new Point(265, 47);
            BtnNum6.Name = "BtnNum6";
            BtnNum6.Size = new Size(126, 38);
            BtnNum6.TabIndex = 5;
            BtnNum6.Text = "6";
            BtnNum6.UseVisualStyleBackColor = true;
            // 
            // BtnNum7
            // 
            BtnNum7.Dock = DockStyle.Fill;
            BtnNum7.Location = new Point(3, 91);
            BtnNum7.Name = "BtnNum7";
            BtnNum7.Size = new Size(125, 38);
            BtnNum7.TabIndex = 6;
            BtnNum7.Text = "7";
            BtnNum7.UseVisualStyleBackColor = true;
            // 
            // BtnNum8
            // 
            BtnNum8.Dock = DockStyle.Fill;
            BtnNum8.Location = new Point(134, 91);
            BtnNum8.Name = "BtnNum8";
            BtnNum8.Size = new Size(125, 38);
            BtnNum8.TabIndex = 7;
            BtnNum8.Text = "8";
            BtnNum8.UseVisualStyleBackColor = true;
            // 
            // BtnNum9
            // 
            BtnNum9.Dock = DockStyle.Fill;
            BtnNum9.Location = new Point(265, 91);
            BtnNum9.Name = "BtnNum9";
            BtnNum9.Size = new Size(126, 38);
            BtnNum9.TabIndex = 8;
            BtnNum9.Text = "9";
            BtnNum9.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(34, 87, 122);
            panel10.Controls.Add(BtnSaveOrder);
            panel10.Controls.Add(BtnTakeAway);
            panel10.Controls.Add(BtnOnSite);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(839, 469);
            panel10.Margin = new Padding(0);
            panel10.Name = "panel10";
            panel10.Size = new Size(391, 180);
            panel10.TabIndex = 5;
            // 
            // BtnSaveOrder
            // 
            BtnSaveOrder.ImageIndex = 3;
            BtnSaveOrder.ImageList = imageList1;
            BtnSaveOrder.Location = new Point(258, 66);
            BtnSaveOrder.Name = "BtnSaveOrder";
            BtnSaveOrder.Size = new Size(119, 62);
            BtnSaveOrder.TabIndex = 2;
            BtnSaveOrder.Text = "Save";
            BtnSaveOrder.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnSaveOrder.UseVisualStyleBackColor = true;
            // 
            // BtnTakeAway
            // 
            BtnTakeAway.ImageIndex = 2;
            BtnTakeAway.ImageList = imageList1;
            BtnTakeAway.Location = new Point(130, 52);
            BtnTakeAway.Name = "BtnTakeAway";
            BtnTakeAway.Size = new Size(75, 57);
            BtnTakeAway.TabIndex = 1;
            BtnTakeAway.Text = "Take Away";
            BtnTakeAway.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnTakeAway.UseVisualStyleBackColor = true;
            // 
            // BtnOnSite
            // 
            BtnOnSite.ImageIndex = 1;
            BtnOnSite.ImageList = imageList1;
            BtnOnSite.Location = new Point(49, 52);
            BtnOnSite.Name = "BtnOnSite";
            BtnOnSite.Size = new Size(75, 57);
            BtnOnSite.TabIndex = 0;
            BtnOnSite.Text = "On Site";
            BtnOnSite.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnOnSite.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-paramètres-240.png");
            imageList1.Images.SetKeyName(1, "icons8-table-100.png");
            imageList1.Images.SetKeyName(2, "icons8-nourriture-à-emporter-100.png");
            imageList1.Images.SetKeyName(3, "icons8-sauvegarder-100.png");
            // 
            // UpdateCardUserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 222, 156);
            Controls.Add(tableLayoutPanel1);
            Name = "UpdateCardUserControl1";
            Size = new Size(1230, 649);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel9.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel10.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel9;
        private Panel panel10;
        private Button BtnSaveOrder;
        private Button BtnTakeAway;
        private Button BtnOnSite;
        private TableLayoutPanel tableLayoutPanel4;
        private Button BtnNum0;
        private Button BtnNum1;
        private Button BtnNum2;
        private Button BtnNum3;
        private Button BtnNum4;
        private Button BtnNum5;
        private Button BtnNum6;
        private Button BtnNum7;
        private Button BtnNum8;
        private Button BtnNum9;
        private ListView listView1;
        private ColumnHeader NumberOfItem;
        private ColumnHeader NameOfItem;
        private ColumnHeader PriceOfItem;
        private Button BtnCategory1;
        private Button BtnCategory2;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel5;
        private Panel panel6;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel5;
        private Button BtnSettings;
        private Button BtnOrderInProgress;
        private Button BtnAddCategory;
        private Button BtnOrderMode;
        private ImageList imageList1;
    }
}
