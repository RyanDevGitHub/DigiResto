using DigiRestoProjet.Model;

namespace DigiRestoProjet.View.AddPage
{
    partial class UpdateCategoryPage
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
            this.LbUpdateCategory = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NameCategoryTextBox = new System.Windows.Forms.TextBox();
            this.BtnUpdateCategory = new System.Windows.Forms.Button();
            this.CheckBoxListTitleLabel = new System.Windows.Forms.Label();
            this.Article_checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.LblChooseColorCategory = new System.Windows.Forms.Label();
            this.BtnColorCategory = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Menu_checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // LbUpdateCategory
            // 
            this.LbUpdateCategory.AutoSize = true;
            this.LbUpdateCategory.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbUpdateCategory.Location = new System.Drawing.Point(63, 40);
            this.LbUpdateCategory.Name = "LbUpdateCategory";
            this.LbUpdateCategory.Size = new System.Drawing.Size(275, 45);
            this.LbUpdateCategory.TabIndex = 1;
            this.LbUpdateCategory.Text = "Update Category";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(36, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 18);
            this.panel1.TabIndex = 3;
            // 
            // NameCategoryTextBox
            // 
            this.NameCategoryTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameCategoryTextBox.Location = new System.Drawing.Point(75, 159);
            this.NameCategoryTextBox.Name = "NameCategoryTextBox";
            this.NameCategoryTextBox.Size = new System.Drawing.Size(253, 33);
            this.NameCategoryTextBox.TabIndex = 4;
            this.NameCategoryTextBox.Text = "New Name of category";
            // 
            // BtnUpdateCategory
            // 
            this.BtnUpdateCategory.Location = new System.Drawing.Point(292, 506);
            this.BtnUpdateCategory.Name = "BtnUpdateCategory";
            this.BtnUpdateCategory.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdateCategory.TabIndex = 6;
            this.BtnUpdateCategory.Text = "Update";
            this.BtnUpdateCategory.UseVisualStyleBackColor = true;
            this.BtnUpdateCategory.Click += new System.EventHandler(this.BtnUpdateCategory_Click);
            // 
            // CheckBoxListTitleLabel
            // 
            this.CheckBoxListTitleLabel.AutoSize = true;
            this.CheckBoxListTitleLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxListTitleLabel.Location = new System.Drawing.Point(12, 221);
            this.CheckBoxListTitleLabel.Name = "CheckBoxListTitleLabel";
            this.CheckBoxListTitleLabel.Size = new System.Drawing.Size(376, 20);
            this.CheckBoxListTitleLabel.TabIndex = 7;
            this.CheckBoxListTitleLabel.Text = "Select Menu and Article to add in your update category";
            this.CheckBoxListTitleLabel.Click += new System.EventHandler(this.CheckBoxListTitleLabel_Click);
            // 
            // Article_checkedListBox1
            // 
            this.Article_checkedListBox1.FormattingEnabled = true;
            this.Article_checkedListBox1.Location = new System.Drawing.Point(12, 267);
            this.Article_checkedListBox1.Name = "Article_checkedListBox1";
            this.Article_checkedListBox1.Size = new System.Drawing.Size(157, 148);
            this.Article_checkedListBox1.TabIndex = 5;
            this.Article_checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.MenuArticle_checkedListBox1_SelectedIndexChanged_1);
            // 
            // LblChooseColorCategory
            // 
            this.LblChooseColorCategory.AutoSize = true;
            this.LblChooseColorCategory.Location = new System.Drawing.Point(49, 434);
            this.LblChooseColorCategory.Name = "LblChooseColorCategory";
            this.LblChooseColorCategory.Size = new System.Drawing.Size(289, 15);
            this.LblChooseColorCategory.TabIndex = 10;
            this.LblChooseColorCategory.Text = "Choose you Baground Color for you update Category";
            // 
            // BtnColorCategory
            // 
            this.BtnColorCategory.Location = new System.Drawing.Point(155, 464);
            this.BtnColorCategory.Name = "BtnColorCategory";
            this.BtnColorCategory.Size = new System.Drawing.Size(75, 23);
            this.BtnColorCategory.TabIndex = 11;
            this.BtnColorCategory.Text = "Color";
            this.BtnColorCategory.UseVisualStyleBackColor = true;
            this.BtnColorCategory.Click += new System.EventHandler(this.BtnColorCategory_Click);
            // 
            // Menu_checkedListBox1
            // 
            this.Menu_checkedListBox1.FormattingEnabled = true;
            this.Menu_checkedListBox1.Location = new System.Drawing.Point(223, 267);
            this.Menu_checkedListBox1.Name = "Menu_checkedListBox1";
            this.Menu_checkedListBox1.Size = new System.Drawing.Size(157, 148);
            this.Menu_checkedListBox1.TabIndex = 12;
            // 
            // UpdateCategoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 554);
            this.Controls.Add(this.Menu_checkedListBox1);
            this.Controls.Add(this.BtnColorCategory);
            this.Controls.Add(this.LblChooseColorCategory);
            this.Controls.Add(this.CheckBoxListTitleLabel);
            this.Controls.Add(this.BtnUpdateCategory);
            this.Controls.Add(this.Article_checkedListBox1);
            this.Controls.Add(this.NameCategoryTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LbUpdateCategory);
            this.Name = "UpdateCategoryPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateCategoryPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LbUpdateCategory;
        private Panel panel1;
        public  TextBox NameCategoryTextBox;
        private Button BtnUpdateCategory;
        private Label CheckBoxListTitleLabel;
        public  CheckedListBox Article_checkedListBox1;
        private Label LblChooseColorCategory;
        private Button BtnColorCategory;
        private ColorDialog colorDialog1;
        public CheckedListBox Menu_checkedListBox1;
    }
}