namespace DigiRestoProjet.View
{
    partial class StatistiqueArticleUserControle
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatistiqueArticleUserControle));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            BtnSearch = new Button();
            dtimeCA = new DateTimePicker();
            cbFilter = new ComboBox();
            btSearchFilter = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnMainMenu = new Button();
            label2 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            cbFilterMonth = new ComboBox();
            btnSearchMonth = new Button();
            chartSold = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tableLayoutPanel6 = new TableLayoutPanel();
            btnExit = new Button();
            label1 = new Label();
            imageList1 = new ImageList(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartRevenue).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartSold).BeginInit();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(chartRevenue, 0, 2);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Size = new Size(194, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // chartRevenue
            // 
            chartArea1.Name = "ChartArea1";
            chartRevenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartRevenue.Legends.Add(legend1);
            chartRevenue.Location = new Point(3, 109);
            chartRevenue.Name = "chartRevenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Revenue";
            chartRevenue.Series.Add(series1);
            chartRevenue.Size = new Size(194, 634);
            chartRevenue.TabIndex = 2;
            chartRevenue.Text = "chart1";
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(10, 3);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(1, 43);
            BtnSearch.TabIndex = 10;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // dtimeCA
            // 
            dtimeCA.Location = new Point(3, 3);
            dtimeCA.Name = "dtimeCA";
            dtimeCA.Size = new Size(1, 23);
            dtimeCA.TabIndex = 0;
            // 
            // cbFilter
            // 
            cbFilter.Dock = DockStyle.Right;
            cbFilter.FormattingEnabled = true;
            cbFilter.Location = new Point(13, 3);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(22, 23);
            cbFilter.TabIndex = 1;
            // 
            // btSearchFilter
            // 
            btSearchFilter.Location = new Point(41, 3);
            btSearchFilter.Name = "btSearchFilter";
            btSearchFilter.Size = new Size(112, 43);
            btSearchFilter.TabIndex = 11;
            btSearchFilter.Text = "Search";
            btSearchFilter.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel3.Controls.Add(btnMainMenu, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Dock = DockStyle.Right;
            btnMainMenu.Location = new Point(4, 5);
            btnMainMenu.Margin = new Padding(4, 5, 4, 5);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(12, 94);
            btnMainMenu.TabIndex = 7;
            btnMainMenu.Text = "Exit";
            btnMainMenu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(23, 0);
            label2.Name = "label2";
            label2.Size = new Size(174, 104);
            label2.TabIndex = 8;
            label2.Text = "Analyse CA";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel4.Controls.Add(chartSold, 0, 2);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 58.00905F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 27.05882F));
            tableLayoutPanel4.Size = new Size(1225, 638);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 4;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.13145F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.920188F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.00704F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 108F));
            tableLayoutPanel5.Controls.Add(cbFilterMonth, 2, 0);
            tableLayoutPanel5.Controls.Add(btnSearchMonth, 3, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(2, 65);
            tableLayoutPanel5.Margin = new Padding(2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel5.Size = new Size(1221, 27);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // cbFilterMonth
            // 
            cbFilterMonth.Dock = DockStyle.Right;
            cbFilterMonth.FormattingEnabled = true;
            cbFilterMonth.Location = new Point(980, 2);
            cbFilterMonth.Margin = new Padding(2);
            cbFilterMonth.Name = "cbFilterMonth";
            cbFilterMonth.Size = new Size(129, 23);
            cbFilterMonth.TabIndex = 1;
            // 
            // btnSearchMonth
            // 
            btnSearchMonth.ImageIndex = 1;
            btnSearchMonth.ImageList = imageList1;
            btnSearchMonth.Location = new Point(1113, 2);
            btnSearchMonth.Margin = new Padding(2);
            btnSearchMonth.Name = "btnSearchMonth";
            btnSearchMonth.Size = new Size(78, 23);
            btnSearchMonth.TabIndex = 11;
            btnSearchMonth.UseVisualStyleBackColor = true;
            btnSearchMonth.Click += btnSearchMonth_Click;
            // 
            // chartSold
            // 
            chartArea2.Name = "ChartArea1";
            chartSold.ChartAreas.Add(chartArea2);
            chartSold.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            chartSold.Legends.Add(legend2);
            chartSold.Location = new Point(2, 96);
            chartSold.Margin = new Padding(2);
            chartSold.Name = "chartSold";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Article";
            chartSold.Series.Add(series2);
            chartSold.Size = new Size(1221, 365);
            chartSold.TabIndex = 2;
            chartSold.Text = "chart1";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel6.Controls.Add(btnExit, 0, 0);
            tableLayoutPanel6.Controls.Add(label1, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(2, 2);
            tableLayoutPanel6.Margin = new Padding(2);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(1221, 59);
            tableLayoutPanel6.TabIndex = 3;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Right;
            btnExit.ImageIndex = 0;
            btnExit.ImageList = imageList1;
            btnExit.Location = new Point(36, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(83, 53);
            btnExit.TabIndex = 7;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(124, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(1095, 59);
            label1.TabIndex = 8;
            label1.Text = "Analyse Sold";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-effacer-240.png");
            imageList1.Images.SetKeyName(1, "icons8-chercher-100.png");
            // 
            // StatistiqueArticleUserControle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel4);
            Name = "StatistiqueArticleUserControle";
            Size = new Size(1225, 638);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartRevenue).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartSold).EndInit();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button BtnSearch;
        private DateTimePicker dtimeCA;
        private ComboBox cbFilter;
        private Button btSearchFilter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnMainMenu;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private ComboBox cbFilterMonth;
        private Button btnSearchMonth;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSold;
        private TableLayoutPanel tableLayoutPanel6;
        private Button btnExit;
        private Label label1;
        private ImageList imageList1;
    }
}
