namespace DigiRestoProjet.View
{
    partial class AnalyseCAUserControle
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalyseCAUserControle));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            BtnSearch = new Button();
            dtimeCA = new DateTimePicker();
            cbFilter = new ComboBox();
            btSearchFilter = new Button();
            chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnMainMenu = new Button();
            label1 = new Label();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartRevenue).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(chartRevenue, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Right;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 58.00905F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 27.05882F));
            tableLayoutPanel1.Size = new Size(1197, 663);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.13145F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.920188F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.00704F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 108F));
            tableLayoutPanel2.Controls.Add(BtnSearch, 0, 0);
            tableLayoutPanel2.Controls.Add(dtimeCA, 0, 0);
            tableLayoutPanel2.Controls.Add(cbFilter, 2, 0);
            tableLayoutPanel2.Controls.Add(btSearchFilter, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(2, 68);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.Size = new Size(1193, 29);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // BtnSearch
            // 
            BtnSearch.ImageIndex = 0;
            BtnSearch.ImageList = imageList2;
            BtnSearch.Location = new Point(209, 2);
            BtnSearch.Margin = new Padding(2);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(78, 25);
            BtnSearch.TabIndex = 10;
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // dtimeCA
            // 
            dtimeCA.Location = new Point(2, 2);
            dtimeCA.Margin = new Padding(2);
            dtimeCA.Name = "dtimeCA";
            dtimeCA.Size = new Size(203, 23);
            dtimeCA.TabIndex = 0;
            // 
            // cbFilter
            // 
            cbFilter.Dock = DockStyle.Right;
            cbFilter.FormattingEnabled = true;
            cbFilter.Location = new Point(952, 2);
            cbFilter.Margin = new Padding(2);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(129, 23);
            cbFilter.TabIndex = 1;
            // 
            // btSearchFilter
            // 
            btSearchFilter.ImageIndex = 0;
            btSearchFilter.ImageList = imageList2;
            btSearchFilter.Location = new Point(1085, 2);
            btSearchFilter.Margin = new Padding(2);
            btSearchFilter.Name = "btSearchFilter";
            btSearchFilter.Size = new Size(78, 25);
            btSearchFilter.TabIndex = 11;
            btSearchFilter.TextAlign = ContentAlignment.MiddleRight;
            btSearchFilter.UseVisualStyleBackColor = true;
            btSearchFilter.Click += btSearchFilter_Click;
            // 
            // chartRevenue
            // 
            chartArea1.Name = "ChartArea1";
            chartRevenue.ChartAreas.Add(chartArea1);
            chartRevenue.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartRevenue.Legends.Add(legend1);
            chartRevenue.Location = new Point(2, 101);
            chartRevenue.Margin = new Padding(2);
            chartRevenue.Name = "chartRevenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Revenue";
            chartRevenue.Series.Add(series1);
            chartRevenue.Size = new Size(1193, 380);
            chartRevenue.TabIndex = 2;
            chartRevenue.Text = "chart1";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel3.Controls.Add(btnMainMenu, 0, 0);
            tableLayoutPanel3.Controls.Add(label1, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(2, 2);
            tableLayoutPanel3.Margin = new Padding(2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1193, 62);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Dock = DockStyle.Right;
            btnMainMenu.ImageIndex = 0;
            btnMainMenu.ImageList = imageList1;
            btnMainMenu.Location = new Point(33, 3);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(83, 56);
            btnMainMenu.TabIndex = 7;
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(121, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(1070, 62);
            label1.TabIndex = 8;
            label1.Text = "Analyse CA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-effacer-240.png");
            imageList1.Images.SetKeyName(1, "icons8-chercher-250.png");
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth8Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "icons8-chercher-100.png");
            // 
            // AnalyseCAUserControle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "AnalyseCAUserControle";
            Size = new Size(1197, 663);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartRevenue).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox cbFilter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnMainMenu;
        private Label label1;
        private Button btSearchFilter;
        private Button BtnSearch;
        private DateTimePicker dtimeCA;
        private ImageList imageList2;
        private ImageList imageList1;
    }
}
