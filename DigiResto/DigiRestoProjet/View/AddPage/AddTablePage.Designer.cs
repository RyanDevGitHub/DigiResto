using DigiRestoProjet.Model;

namespace DigiRestoProjet.View.AddPage
{
    partial class AddTablePage
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
            this.labTable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SizeTableTextBox = new System.Windows.Forms.TextBox();
            this.BtnAddNewCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labTable
            // 
            this.labTable.AutoSize = true;
            this.labTable.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labTable.Location = new System.Drawing.Point(106, 21);
            this.labTable.Name = "labTable";
            this.labTable.Size = new System.Drawing.Size(171, 45);
            this.labTable.TabIndex = 1;
            this.labTable.Text = "Add Table";
            this.labTable.Click += new System.EventHandler(this.labArticle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(36, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 18);
            this.panel1.TabIndex = 3;
            // 
            // SizeTableTextBox
            // 
            this.SizeTableTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SizeTableTextBox.Location = new System.Drawing.Point(75, 159);
            this.SizeTableTextBox.Name = "SizeTableTextBox";
            this.SizeTableTextBox.Size = new System.Drawing.Size(253, 33);
            this.SizeTableTextBox.TabIndex = 4;
            this.SizeTableTextBox.Text = "Size of Table";
            // 
            // BtnAddNewCategory
            // 
            this.BtnAddNewCategory.Location = new System.Drawing.Point(293, 229);
            this.BtnAddNewCategory.Name = "BtnAddNewCategory";
            this.BtnAddNewCategory.Size = new System.Drawing.Size(75, 23);
            this.BtnAddNewCategory.TabIndex = 6;
            this.BtnAddNewCategory.Text = "Add";
            this.BtnAddNewCategory.UseVisualStyleBackColor = true;
            this.BtnAddNewCategory.Click += new System.EventHandler(this.BtnAddNewTable_Click);
            // 
            // AddTablePage1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 316);
            this.Controls.Add(this.BtnAddNewCategory);
            this.Controls.Add(this.SizeTableTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labTable);
            this.Name = "AddTablePage1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTablePage";
            this.Load += new System.EventHandler(this.AddArticlePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labTable;
        private Panel panel1;
        private TextBox SizeTableTextBox;
        private Button BtnAddNewCategory;
    }
}