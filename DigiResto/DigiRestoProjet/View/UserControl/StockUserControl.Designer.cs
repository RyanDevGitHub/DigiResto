using DigiRestoProjet.Model;

namespace DigiRestoProjet
{
    public partial class StockUserControl
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
        public void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockUserControl));
            panel1 = new Panel();
            panel2 = new Panel();
            StockdataGridView = new DataGridView();
            comboBox1 = new ComboBox();
            panel3 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel5 = new Panel();
            BtnAddStock = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            label1 = new Label();
            panel6 = new Panel();
            btnExit = new Button();
            BtnSetting = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewButtonColumn();
            Column4 = new DataGridViewButtonColumn();
            imageList1 = new ImageList(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StockdataGridView).BeginInit();
            panel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(-5, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(1236, 3);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(StockdataGridView);
            panel2.Location = new Point(19, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(1190, 519);
            panel2.TabIndex = 2;
            // 
            // StockdataGridView
            // 
            StockdataGridView.AllowUserToAddRows = false;
            StockdataGridView.AllowUserToDeleteRows = false;
            StockdataGridView.AllowUserToResizeColumns = false;
            StockdataGridView.AllowUserToResizeRows = false;
            StockdataGridView.BackgroundColor = Color.White;
            StockdataGridView.BorderStyle = BorderStyle.Fixed3D;
            StockdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StockdataGridView.Dock = DockStyle.Fill;
            StockdataGridView.Location = new Point(0, 0);
            StockdataGridView.MultiSelect = false;
            StockdataGridView.Name = "StockdataGridView";
            StockdataGridView.RowHeadersWidth = 62;
            StockdataGridView.RowTemplate.Height = 25;
            StockdataGridView.Size = new Size(1190, 519);
            StockdataGridView.TabIndex = 0;
            StockdataGridView.CellContentClick += StockdataGridView_CellContentClick_1;
            StockdataGridView.DataError += StockdataGridView_DataError;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Bottom;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(823, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(407, 23);
            comboBox1.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel2);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 592);
            panel3.Name = "panel3";
            panel3.Size = new Size(1233, 82);
            panel3.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.Controls.Add(panel5, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 15);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1233, 67);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(BtnAddStock);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(413, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(404, 61);
            panel5.TabIndex = 0;
            // 
            // BtnAddStock
            // 
            BtnAddStock.Anchor = AnchorStyles.None;
            BtnAddStock.Location = new Point(132, 8);
            BtnAddStock.Name = "BtnAddStock";
            BtnAddStock.Size = new Size(143, 45);
            BtnAddStock.TabIndex = 0;
            BtnAddStock.Text = "Add Stock";
            BtnAddStock.UseVisualStyleBackColor = true;
            BtnAddStock.Click += BtnAddStock_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(34, 87, 122);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.Controls.Add(panel4, 1, 0);
            tableLayoutPanel1.Controls.Add(comboBox1, 2, 0);
            tableLayoutPanel1.Controls.Add(panel6, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1233, 67);
            tableLayoutPanel1.TabIndex = 6;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(34, 87, 122);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(413, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(404, 61);
            panel4.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(193, 9);
            label1.Margin = new Padding(12);
            label1.Name = "label1";
            label1.Size = new Size(117, 38);
            label1.TabIndex = 0;
            label1.Text = "Stock";
            label1.Click += label1_Click_1;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnExit);
            panel6.Controls.Add(BtnSetting);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(404, 61);
            panel6.TabIndex = 5;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.None;
            btnExit.ImageKey = "icons8-accueil-100.png";
            btnExit.ImageList = imageList1;
            btnExit.Location = new Point(163, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 54);
            btnExit.TabIndex = 2;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // BtnSetting
            // 
            BtnSetting.Anchor = AnchorStyles.None;
            BtnSetting.ImageKey = "icons8-paramètres-240.png";
            BtnSetting.ImageList = imageList1;
            BtnSetting.Location = new Point(281, 4);
            BtnSetting.Name = "BtnSetting";
            BtnSetting.Size = new Size(112, 54);
            BtnSetting.TabIndex = 0;
            BtnSetting.UseVisualStyleBackColor = true;
            BtnSetting.Click += BtnSetting_Click;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-paramètres-240.png");
            imageList1.Images.SetKeyName(1, "icons8-accueil-100.png");
            // 
            // StockUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 87, 122);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "StockUserControl";
            Size = new Size(1233, 674);
            Load += StockUserControl_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)StockdataGridView).EndInit();
            panel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        public DataGridView StockdataGridView;
        private ComboBox comboBox1;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel4;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel5;
        private Button BtnAddStock;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewButtonColumn Column3;
        private DataGridViewButtonColumn Column4;
        private Panel panel6;
        private Button BtnSetting;
        private Button btnExit;
        private ImageList imageList1;
    }
}
