using DigiRestoProjet.Model;

namespace DigiRestoProjet.View.AddPage
{
    partial class UpdateTablePage
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
            this.LbUpdateTable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnUpdateCategory = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SizeUpdateTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LbUpdateTable
            // 
            this.LbUpdateTable.AutoSize = true;
            this.LbUpdateTable.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbUpdateTable.Location = new System.Drawing.Point(88, 30);
            this.LbUpdateTable.Name = "LbUpdateTable";
            this.LbUpdateTable.Size = new System.Drawing.Size(217, 45);
            this.LbUpdateTable.TabIndex = 1;
            this.LbUpdateTable.Text = "Update Table";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(36, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 18);
            this.panel1.TabIndex = 3;
            // 
            // BtnUpdateCategory
            // 
            this.BtnUpdateCategory.Location = new System.Drawing.Point(292, 234);
            this.BtnUpdateCategory.Name = "BtnUpdateCategory";
            this.BtnUpdateCategory.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdateCategory.TabIndex = 6;
            this.BtnUpdateCategory.Text = "Update";
            this.BtnUpdateCategory.UseVisualStyleBackColor = true;
            this.BtnUpdateCategory.Click += new System.EventHandler(this.BtnUpdateTable_Click);
            // 
            // SizeUpdateTextBox
            // 
            this.SizeUpdateTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SizeUpdateTextBox.Location = new System.Drawing.Point(74, 158);
            this.SizeUpdateTextBox.Name = "SizeUpdateTextBox";
            this.SizeUpdateTextBox.Size = new System.Drawing.Size(253, 33);
            this.SizeUpdateTextBox.TabIndex = 7;
            this.SizeUpdateTextBox.Text = "New size of table";
            // 
            // UpdateTablePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 316);
            this.Controls.Add(this.SizeUpdateTextBox);
            this.Controls.Add(this.BtnUpdateCategory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LbUpdateTable);
            this.Name = "UpdateTablePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateTablePage";
            this.Load += new System.EventHandler(this.UpdateTablePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LbUpdateTable;
        private Panel panel1;
        private Button BtnUpdateCategory;
        private ColorDialog colorDialog1;
        public TextBox SizeUpdateTextBox;
    }
}