using DigiRestoProjet.Model;

namespace DigiRestoProjet.View.AddPage
{
    partial class AddCategoryPage
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
            this.TitleFormLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NameCategoryTextBox = new System.Windows.Forms.TextBox();
            this.BtnAddNewCategory = new System.Windows.Forms.Button();
            this.CheckBoxListTitleLabel = new System.Windows.Forms.Label();
            this.MenuArticle_checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.BtnColorCategory = new System.Windows.Forms.Button();
            this.LblChooseColorCategory = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Menu_checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // TitleFormLabel
            // 
            this.TitleFormLabel.AutoSize = true;
            this.TitleFormLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleFormLabel.Location = new System.Drawing.Point(87, 40);
            this.TitleFormLabel.Name = "TitleFormLabel";
            this.TitleFormLabel.Size = new System.Drawing.Size(229, 45);
            this.TitleFormLabel.TabIndex = 1;
            this.TitleFormLabel.Text = "Add Category";
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
            this.NameCategoryTextBox.Text = "Name of category";
            // 
            // BtnAddNewCategory
            // 
            this.BtnAddNewCategory.Location = new System.Drawing.Point(292, 506);
            this.BtnAddNewCategory.Name = "BtnAddNewCategory";
            this.BtnAddNewCategory.Size = new System.Drawing.Size(75, 23);
            this.BtnAddNewCategory.TabIndex = 6;
            this.BtnAddNewCategory.Text = "Add";
            this.BtnAddNewCategory.UseVisualStyleBackColor = true;
            this.BtnAddNewCategory.Click += new System.EventHandler(this.BtnAddNewCategory_Click);
            // 
            // CheckBoxListTitleLabel
            // 
            this.CheckBoxListTitleLabel.AutoSize = true;
            this.CheckBoxListTitleLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxListTitleLabel.Location = new System.Drawing.Point(12, 227);
            this.CheckBoxListTitleLabel.Name = "CheckBoxListTitleLabel";
            this.CheckBoxListTitleLabel.Size = new System.Drawing.Size(356, 20);
            this.CheckBoxListTitleLabel.TabIndex = 7;
            this.CheckBoxListTitleLabel.Text = "Select Menu and Article to add in your new category";
            // 
            // MenuArticle_checkedListBox1
            // 
            this.MenuArticle_checkedListBox1.FormattingEnabled = true;
            this.MenuArticle_checkedListBox1.Location = new System.Drawing.Point(12, 262);
            this.MenuArticle_checkedListBox1.Name = "MenuArticle_checkedListBox1";
            this.MenuArticle_checkedListBox1.Size = new System.Drawing.Size(154, 148);
            this.MenuArticle_checkedListBox1.TabIndex = 5;
            this.MenuArticle_checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.MenuArticle_checkedListBox1_SelectedIndexChanged);
            // 
            // BtnColorCategory
            // 
            this.BtnColorCategory.Location = new System.Drawing.Point(160, 465);
            this.BtnColorCategory.Name = "BtnColorCategory";
            this.BtnColorCategory.Size = new System.Drawing.Size(75, 23);
            this.BtnColorCategory.TabIndex = 8;
            this.BtnColorCategory.Text = "Color";
            this.BtnColorCategory.UseVisualStyleBackColor = true;
            this.BtnColorCategory.Click += new System.EventHandler(this.BtnColorCategory_Click);
            // 
            // LblChooseColorCategory
            // 
            this.LblChooseColorCategory.AutoSize = true;
            this.LblChooseColorCategory.Location = new System.Drawing.Point(64, 433);
            this.LblChooseColorCategory.Name = "LblChooseColorCategory";
            this.LblChooseColorCategory.Size = new System.Drawing.Size(274, 15);
            this.LblChooseColorCategory.TabIndex = 9;
            this.LblChooseColorCategory.Text = "Choose you Baground Color for you new Category";
            // 
            // Menu_checkedListBox1
            // 
            this.Menu_checkedListBox1.FormattingEnabled = true;
            this.Menu_checkedListBox1.Location = new System.Drawing.Point(211, 262);
            this.Menu_checkedListBox1.Name = "Menu_checkedListBox1";
            this.Menu_checkedListBox1.Size = new System.Drawing.Size(157, 148);
            this.Menu_checkedListBox1.TabIndex = 13;
            // 
            // AddCategoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 554);
            this.Controls.Add(this.Menu_checkedListBox1);
            this.Controls.Add(this.LblChooseColorCategory);
            this.Controls.Add(this.BtnColorCategory);
            this.Controls.Add(this.CheckBoxListTitleLabel);
            this.Controls.Add(this.BtnAddNewCategory);
            this.Controls.Add(this.MenuArticle_checkedListBox1);
            this.Controls.Add(this.NameCategoryTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitleFormLabel);
            this.Name = "AddCategoryPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCategoryPage";
            this.Load += new System.EventHandler(this.AddCategoryPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TitleFormLabel;
        private Panel panel1;
        private TextBox NameCategoryTextBox;
        private Button BtnAddNewCategory;
        private Label CheckBoxListTitleLabel;
        private CheckedListBox MenuArticle_checkedListBox1;
        private Button BtnColorCategory;
        private Label LblChooseColorCategory;
        private ColorDialog colorDialog1;
        public CheckedListBox Menu_checkedListBox1;
    }
}