namespace DigiRestoProjet.View.AddPage
{
    partial class AddMenuPage
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
            this.labMenu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NameMenuTextBox = new System.Windows.Forms.TextBox();
            this.BtnAddNewArticle = new System.Windows.Forms.Button();
            this.DescMenuTextBox = new System.Windows.Forms.TextBox();
            this.PriceMenuTextBox = new System.Windows.Forms.TextBox();
            this.checkedComboBoxEnter = new CheckComboBoxTest.CheckedComboBox();
            this.checkedComboBoxDish = new CheckComboBoxTest.CheckedComboBox();
            this.checkedComboBoxDessert = new CheckComboBoxTest.CheckedComboBox();
            this.labelChoiceEnter = new System.Windows.Forms.Label();
            this.labelChoiceDIsh = new System.Windows.Forms.Label();
            this.labelChoiceDessert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labMenu
            // 
            this.labMenu.AutoSize = true;
            this.labMenu.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labMenu.Location = new System.Drawing.Point(416, 9);
            this.labMenu.Name = "labMenu";
            this.labMenu.Size = new System.Drawing.Size(178, 45);
            this.labMenu.TabIndex = 1;
            this.labMenu.Text = "Add Menu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(36, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 18);
            this.panel1.TabIndex = 3;
            // 
            // NameMenuTextBox
            // 
            this.NameMenuTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameMenuTextBox.Location = new System.Drawing.Point(75, 181);
            this.NameMenuTextBox.Name = "NameMenuTextBox";
            this.NameMenuTextBox.Size = new System.Drawing.Size(253, 33);
            this.NameMenuTextBox.TabIndex = 4;
            this.NameMenuTextBox.Text = "Name of Menu";
            // 
            // BtnAddNewArticle
            // 
            this.BtnAddNewArticle.Location = new System.Drawing.Point(475, 497);
            this.BtnAddNewArticle.Name = "BtnAddNewArticle";
            this.BtnAddNewArticle.Size = new System.Drawing.Size(75, 23);
            this.BtnAddNewArticle.TabIndex = 6;
            this.BtnAddNewArticle.Text = "Add";
            this.BtnAddNewArticle.UseVisualStyleBackColor = true;
            this.BtnAddNewArticle.Click += new System.EventHandler(this.BtnAddNewArticle_Click);
            // 
            // DescMenuTextBox
            // 
            this.DescMenuTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescMenuTextBox.Location = new System.Drawing.Point(75, 292);
            this.DescMenuTextBox.Name = "DescMenuTextBox";
            this.DescMenuTextBox.Size = new System.Drawing.Size(253, 33);
            this.DescMenuTextBox.TabIndex = 8;
            this.DescMenuTextBox.Text = "Description of Menu";
            // 
            // PriceMenuTextBox
            // 
            this.PriceMenuTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PriceMenuTextBox.Location = new System.Drawing.Point(127, 415);
            this.PriceMenuTextBox.Name = "PriceMenuTextBox";
            this.PriceMenuTextBox.Size = new System.Drawing.Size(132, 33);
            this.PriceMenuTextBox.TabIndex = 9;
            this.PriceMenuTextBox.Text = "Price of Menu";
            // 
            // checkedComboBoxEnter
            // 
            this.checkedComboBoxEnter.CheckOnClick = true;
            this.checkedComboBoxEnter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.checkedComboBoxEnter.DropDownHeight = 1;
            this.checkedComboBoxEnter.FormattingEnabled = true;
            this.checkedComboBoxEnter.IntegralHeight = false;
            this.checkedComboBoxEnter.Location = new System.Drawing.Point(732, 190);
            this.checkedComboBoxEnter.Name = "checkedComboBoxEnter";
            this.checkedComboBoxEnter.Size = new System.Drawing.Size(178, 24);
            this.checkedComboBoxEnter.TabIndex = 10;
            this.checkedComboBoxEnter.ValueSeparator = ", ";
            // 
            // checkedComboBoxDish
            // 
            this.checkedComboBoxDish.CheckOnClick = true;
            this.checkedComboBoxDish.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.checkedComboBoxDish.DropDownHeight = 1;
            this.checkedComboBoxDish.FormattingEnabled = true;
            this.checkedComboBoxDish.IntegralHeight = false;
            this.checkedComboBoxDish.Location = new System.Drawing.Point(732, 300);
            this.checkedComboBoxDish.Name = "checkedComboBoxDish";
            this.checkedComboBoxDish.Size = new System.Drawing.Size(178, 24);
            this.checkedComboBoxDish.TabIndex = 11;
            this.checkedComboBoxDish.ValueSeparator = ", ";
            // 
            // checkedComboBoxDessert
            // 
            this.checkedComboBoxDessert.CheckOnClick = true;
            this.checkedComboBoxDessert.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.checkedComboBoxDessert.DropDownHeight = 1;
            this.checkedComboBoxDessert.FormattingEnabled = true;
            this.checkedComboBoxDessert.IntegralHeight = false;
            this.checkedComboBoxDessert.Location = new System.Drawing.Point(732, 415);
            this.checkedComboBoxDessert.Name = "checkedComboBoxDessert";
            this.checkedComboBoxDessert.Size = new System.Drawing.Size(178, 24);
            this.checkedComboBoxDessert.TabIndex = 12;
            this.checkedComboBoxDessert.ValueSeparator = ", ";
            // 
            // labelChoiceEnter
            // 
            this.labelChoiceEnter.AutoSize = true;
            this.labelChoiceEnter.Location = new System.Drawing.Point(416, 190);
            this.labelChoiceEnter.Name = "labelChoiceEnter";
            this.labelChoiceEnter.Size = new System.Drawing.Size(296, 15);
            this.labelChoiceEnter.TabIndex = 13;
            this.labelChoiceEnter.Text = "Select the entries that will be accessible from the menu";
            // 
            // labelChoiceDIsh
            // 
            this.labelChoiceDIsh.AutoSize = true;
            this.labelChoiceDIsh.Location = new System.Drawing.Point(415, 300);
            this.labelChoiceDIsh.Name = "labelChoiceDIsh";
            this.labelChoiceDIsh.Size = new System.Drawing.Size(294, 15);
            this.labelChoiceDIsh.TabIndex = 14;
            this.labelChoiceDIsh.Text = "Select the dishes that will be accessible from the menu";
            // 
            // labelChoiceDessert
            // 
            this.labelChoiceDessert.AutoSize = true;
            this.labelChoiceDessert.Location = new System.Drawing.Point(416, 415);
            this.labelChoiceDessert.Name = "labelChoiceDessert";
            this.labelChoiceDessert.Size = new System.Drawing.Size(303, 15);
            this.labelChoiceDessert.TabIndex = 15;
            this.labelChoiceDessert.Text = "Select the desserts that will be accessible from the menu";
            // 
            // AddMenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 554);
            this.Controls.Add(this.labelChoiceDessert);
            this.Controls.Add(this.labelChoiceDIsh);
            this.Controls.Add(this.labelChoiceEnter);
            this.Controls.Add(this.checkedComboBoxDessert);
            this.Controls.Add(this.checkedComboBoxDish);
            this.Controls.Add(this.checkedComboBoxEnter);
            this.Controls.Add(this.PriceMenuTextBox);
            this.Controls.Add(this.DescMenuTextBox);
            this.Controls.Add(this.BtnAddNewArticle);
            this.Controls.Add(this.NameMenuTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labMenu);
            this.Name = "AddMenuPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMenuPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labMenu;
        private Panel panel1;
        private TextBox NameMenuTextBox;
        private Button BtnAddNewArticle;
        private TextBox DescMenuTextBox;
        private TextBox PriceMenuTextBox;
        private CheckComboBoxTest.CheckedComboBox checkedComboBoxEnter;
        private CheckComboBoxTest.CheckedComboBox checkedComboBoxDish;
        private CheckComboBoxTest.CheckedComboBox checkedComboBoxDessert;
        private Label labelChoiceEnter;
        private Label labelChoiceDIsh;
        private Label labelChoiceDessert;
    }
}