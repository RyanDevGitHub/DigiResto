using DigiRestoProjet.Model;



namespace DigiRestoProjet.View.AddPage
{
    partial class AddArticlePage
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
            this.labArticle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NameArticleTextBox = new System.Windows.Forms.TextBox();
            this.BtnAddNewArticle = new System.Windows.Forms.Button();
            this.ArticleTitleLabel = new System.Windows.Forms.Label();
            this.DescArticleTextBox = new System.Windows.Forms.TextBox();
            this.PriceArticleTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewAddArticle = new System.Windows.Forms.DataGridView();
            this.CheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddArticle)).BeginInit();
            this.SuspendLayout();
            // 
            // labArticle
            // 
            this.labArticle.AutoSize = true;
            this.labArticle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labArticle.Location = new System.Drawing.Point(395, 24);
            this.labArticle.Name = "labArticle";
            this.labArticle.Size = new System.Drawing.Size(191, 45);
            this.labArticle.TabIndex = 1;
            this.labArticle.Text = "Add Article";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(36, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 18);
            this.panel1.TabIndex = 3;
            // 
            // NameArticleTextBox
            // 
            this.NameArticleTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameArticleTextBox.Location = new System.Drawing.Point(76, 197);
            this.NameArticleTextBox.Name = "NameArticleTextBox";
            this.NameArticleTextBox.Size = new System.Drawing.Size(253, 33);
            this.NameArticleTextBox.TabIndex = 4;
            this.NameArticleTextBox.Text = "Name of Article";
            this.NameArticleTextBox.TextChanged += new System.EventHandler(this.NameArticleTextBox_TextChanged);
            // 
            // BtnAddNewArticle
            // 
            this.BtnAddNewArticle.Location = new System.Drawing.Point(452, 519);
            this.BtnAddNewArticle.Name = "BtnAddNewArticle";
            this.BtnAddNewArticle.Size = new System.Drawing.Size(75, 23);
            this.BtnAddNewArticle.TabIndex = 6;
            this.BtnAddNewArticle.Text = "Add";
            this.BtnAddNewArticle.UseVisualStyleBackColor = true;
            this.BtnAddNewArticle.Click += new System.EventHandler(this.BtnAddNewArticle_Click);
            // 
            // ArticleTitleLabel
            // 
            this.ArticleTitleLabel.AutoSize = true;
            this.ArticleTitleLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ArticleTitleLabel.Location = new System.Drawing.Point(569, 118);
            this.ArticleTitleLabel.Name = "ArticleTitleLabel";
            this.ArticleTitleLabel.Size = new System.Drawing.Size(248, 20);
            this.ArticleTitleLabel.TabIndex = 7;
            this.ArticleTitleLabel.Text = "Select Ingredient in your new Article";
            // 
            // DescArticleTextBox
            // 
            this.DescArticleTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescArticleTextBox.Location = new System.Drawing.Point(76, 287);
            this.DescArticleTextBox.Name = "DescArticleTextBox";
            this.DescArticleTextBox.Size = new System.Drawing.Size(253, 33);
            this.DescArticleTextBox.TabIndex = 8;
            this.DescArticleTextBox.Text = "Description of Article";
            // 
            // PriceArticleTextBox
            // 
            this.PriceArticleTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PriceArticleTextBox.Location = new System.Drawing.Point(138, 402);
            this.PriceArticleTextBox.Name = "PriceArticleTextBox";
            this.PriceArticleTextBox.Size = new System.Drawing.Size(132, 33);
            this.PriceArticleTextBox.TabIndex = 9;
            this.PriceArticleTextBox.Text = "Price of Article";
            // 
            // dataGridViewAddArticle
            // 
            this.dataGridViewAddArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddArticle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBoxColumn,
            this.QuantityColumn,
            this.UnitColumn});
            this.dataGridViewAddArticle.Location = new System.Drawing.Point(452, 154);
            this.dataGridViewAddArticle.Name = "dataGridViewAddArticle";
            this.dataGridViewAddArticle.RowTemplate.Height = 25;
            this.dataGridViewAddArticle.Size = new System.Drawing.Size(520, 359);
            this.dataGridViewAddArticle.TabIndex = 10;
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
            // AddArticlePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 554);
            this.Controls.Add(this.dataGridViewAddArticle);
            this.Controls.Add(this.PriceArticleTextBox);
            this.Controls.Add(this.DescArticleTextBox);
            this.Controls.Add(this.ArticleTitleLabel);
            this.Controls.Add(this.BtnAddNewArticle);
            this.Controls.Add(this.NameArticleTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labArticle);
            this.Name = "AddArticlePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddArticlePage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddArticle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion



        private Label labArticle;
        private Panel panel1;
        private TextBox NameArticleTextBox;
        private Button BtnAddNewArticle;
        private Label ArticleTitleLabel;
        private TextBox DescArticleTextBox;
        private TextBox PriceArticleTextBox;
        private DataGridView dataGridViewAddArticle;
        private DataGridViewCheckBoxColumn CheckBoColumn;
        private DataGridViewTextBoxColumn QuantityColumn;
        private DataGridViewComboBoxColumn UnitColumn;
        private DataGridViewCheckBoxColumn CheckBoxColumn;
    }
}