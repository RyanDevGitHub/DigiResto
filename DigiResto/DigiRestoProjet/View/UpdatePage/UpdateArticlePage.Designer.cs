namespace DigiRestoProjet.View
{
    partial class UpdateArticlePage
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
            this.LbUpdateArticle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NameArticleUpdateTextBox = new System.Windows.Forms.TextBox();
            this.BtnUpdateCategory = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.PriceArticleUpdateTextBox = new System.Windows.Forms.TextBox();
            this.ArticleTitleLabel = new System.Windows.Forms.Label();
            this.DescArticleUpdateTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewUpdateArticle = new System.Windows.Forms.DataGridView();
            this.CheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdateArticle)).BeginInit();
            this.SuspendLayout();
            // 
            // LbUpdateArticle
            // 
            this.LbUpdateArticle.AutoSize = true;
            this.LbUpdateArticle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbUpdateArticle.Location = new System.Drawing.Point(357, 23);
            this.LbUpdateArticle.Name = "LbUpdateArticle";
            this.LbUpdateArticle.Size = new System.Drawing.Size(237, 45);
            this.LbUpdateArticle.TabIndex = 1;
            this.LbUpdateArticle.Text = "Update Article";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(36, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 18);
            this.panel1.TabIndex = 3;
            // 
            // NameArticleUpdateTextBox
            // 
            this.NameArticleUpdateTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameArticleUpdateTextBox.Location = new System.Drawing.Point(76, 197);
            this.NameArticleUpdateTextBox.Name = "NameArticleUpdateTextBox";
            this.NameArticleUpdateTextBox.Size = new System.Drawing.Size(253, 33);
            this.NameArticleUpdateTextBox.TabIndex = 4;
            this.NameArticleUpdateTextBox.Text = "New Name of article";
            // 
            // BtnUpdateCategory
            // 
            this.BtnUpdateCategory.Location = new System.Drawing.Point(452, 519);
            this.BtnUpdateCategory.Name = "BtnUpdateCategory";
            this.BtnUpdateCategory.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdateCategory.TabIndex = 6;
            this.BtnUpdateCategory.Text = "Update";
            this.BtnUpdateCategory.UseVisualStyleBackColor = true;
            this.BtnUpdateCategory.Click += new System.EventHandler(this.BtnUpdateCategory_Click);
            // 
            // PriceArticleUpdateTextBox
            // 
            this.PriceArticleUpdateTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PriceArticleUpdateTextBox.Location = new System.Drawing.Point(138, 402);
            this.PriceArticleUpdateTextBox.Name = "PriceArticleUpdateTextBox";
            this.PriceArticleUpdateTextBox.Size = new System.Drawing.Size(111, 33);
            this.PriceArticleUpdateTextBox.TabIndex = 8;
            this.PriceArticleUpdateTextBox.Text = "New Price";
            this.PriceArticleUpdateTextBox.TextChanged += new System.EventHandler(this.PriceArticleUpdateTextBox_TextChanged);
            // 
            // ArticleTitleLabel
            // 
            this.ArticleTitleLabel.AutoSize = true;
            this.ArticleTitleLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ArticleTitleLabel.Location = new System.Drawing.Point(569, 118);
            this.ArticleTitleLabel.Name = "ArticleTitleLabel";
            this.ArticleTitleLabel.Size = new System.Drawing.Size(248, 20);
            this.ArticleTitleLabel.TabIndex = 9;
            this.ArticleTitleLabel.Text = "Select Ingredient in your new Article";
            // 
            // DescArticleTextBox
            // 
            this.DescArticleUpdateTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescArticleUpdateTextBox.Location = new System.Drawing.Point(76, 287);
            this.DescArticleUpdateTextBox.Name = "DescArticleTextBox";
            this.DescArticleUpdateTextBox.Size = new System.Drawing.Size(253, 33);
            this.DescArticleUpdateTextBox.TabIndex = 10;
            this.DescArticleUpdateTextBox.Text = "Description of Article";
            this.DescArticleUpdateTextBox.TextChanged += new System.EventHandler(this.DescArticleTextBox_TextChanged);
            // 
            // dataGridViewUpdateArticle
            // 
            this.dataGridViewUpdateArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpdateArticle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBoxColumn,
            this.QuantityColumn,
            this.UnitColumn});
            this.dataGridViewUpdateArticle.Location = new System.Drawing.Point(452, 154);
            this.dataGridViewUpdateArticle.Name = "dataGridViewUpdateArticle";
            this.dataGridViewUpdateArticle.RowTemplate.Height = 25;
            this.dataGridViewUpdateArticle.Size = new System.Drawing.Size(520, 359);
            this.dataGridViewUpdateArticle.TabIndex = 11;
            // 
            // CheckBoxColumn
            // 
            this.CheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CheckBoxColumn.HeaderText = "Check The Ingrdients";
            this.CheckBoxColumn.Name = "CheckBoxColumn";
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QuantityColumn.HeaderText = "Quantity of Ingredient";
            this.QuantityColumn.Name = "QuantityColumn";
            // 
            // UnitColumn
            // 
            this.UnitColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UnitColumn.HeaderText = "Units Of Quantity";
            this.UnitColumn.Items.AddRange(new object[] {
            "mL",
            "L",
            "g",
            "Kg",
            "T"});
            this.UnitColumn.Name = "UnitColumn";
            // 
            // UpdateArticlePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 554);
            this.Controls.Add(this.dataGridViewUpdateArticle);
            this.Controls.Add(this.DescArticleUpdateTextBox);
            this.Controls.Add(this.ArticleTitleLabel);
            this.Controls.Add(this.PriceArticleUpdateTextBox);
            this.Controls.Add(this.BtnUpdateCategory);
            this.Controls.Add(this.NameArticleUpdateTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LbUpdateArticle);
            this.Name = "UpdateArticlePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateArticlePage";
            this.Load += new System.EventHandler(this.UpdateArticlePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdateArticle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LbUpdateArticle;
        private Panel panel1;
        public TextBox NameArticleUpdateTextBox;
        private Button BtnUpdateCategory;
        private ColorDialog colorDialog1;
        public TextBox PriceArticleUpdateTextBox;
        private Label ArticleTitleLabel;
        public TextBox DescArticleUpdateTextBox;
        public DataGridView dataGridViewUpdateArticle;
        public DataGridViewCheckBoxColumn CheckBoxColumn;
        public DataGridViewTextBoxColumn QuantityColumn;
        public DataGridViewComboBoxColumn UnitColumn;
    }
}