

namespace DigiRestoProjet.View
{
    partial class ManageTablePage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabManageTable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTable = new System.Windows.Forms.ComboBox();
            this.BtnAddTable = new System.Windows.Forms.Button();
            this.BtnUpdateTable = new System.Windows.Forms.Button();
            this.BtnDeleteTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(39, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 18);
            this.panel1.TabIndex = 4;
            // 
            // LabManageTable
            // 
            this.LabManageTable.AutoSize = true;
            this.LabManageTable.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabManageTable.Location = new System.Drawing.Point(91, 22);
            this.LabManageTable.Name = "LabManageTable";
            this.LabManageTable.Size = new System.Drawing.Size(229, 45);
            this.LabManageTable.TabIndex = 2;
            this.LabManageTable.Text = "Manage Table";
            this.LabManageTable.Click += new System.EventHandler(this.labArticle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "select the table you want to edit or modify";
            // 
            // comboBoxTable
            // 
            this.comboBoxTable.FormattingEnabled = true;
            this.comboBoxTable.Location = new System.Drawing.Point(39, 205);
            this.comboBoxTable.Name = "comboBoxTable";
            this.comboBoxTable.Size = new System.Drawing.Size(228, 23);
            this.comboBoxTable.TabIndex = 6;
            this.comboBoxTable.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BtnAddTable
            // 
            this.BtnAddTable.Location = new System.Drawing.Point(138, 489);
            this.BtnAddTable.Name = "BtnAddTable";
            this.BtnAddTable.Size = new System.Drawing.Size(114, 31);
            this.BtnAddTable.TabIndex = 7;
            this.BtnAddTable.Text = "Add Table";
            this.BtnAddTable.UseVisualStyleBackColor = true;
            this.BtnAddTable.Click += new System.EventHandler(this.BtnAddTable_Click);
            // 
            // BtnUpdateTable
            // 
            this.BtnUpdateTable.Location = new System.Drawing.Point(295, 205);
            this.BtnUpdateTable.Name = "BtnUpdateTable";
            this.BtnUpdateTable.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdateTable.TabIndex = 8;
            this.BtnUpdateTable.Text = "Update";
            this.BtnUpdateTable.UseVisualStyleBackColor = true;
            this.BtnUpdateTable.Click += new System.EventHandler(this.BtnUpdateTable_Click);
            // 
            // BtnDeleteTable
            // 
            this.BtnDeleteTable.Location = new System.Drawing.Point(295, 249);
            this.BtnDeleteTable.Name = "BtnDeleteTable";
            this.BtnDeleteTable.Size = new System.Drawing.Size(75, 23);
            this.BtnDeleteTable.TabIndex = 9;
            this.BtnDeleteTable.Text = "Delete";
            this.BtnDeleteTable.UseVisualStyleBackColor = true;
            this.BtnDeleteTable.Click += new System.EventHandler(this.BtnDeleteTable_Click);
            // 
            // ManageTablePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 571);
            this.Controls.Add(this.BtnDeleteTable);
            this.Controls.Add(this.BtnUpdateTable);
            this.Controls.Add(this.BtnAddTable);
            this.Controls.Add(this.comboBoxTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabManageTable);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManageTablePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageTablePage";
            this.Load += new System.EventHandler(this.ManageCategoryPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label LabManageTable;
        private Label label1;
        private ComboBox comboBoxTable;
        private Button BtnAddTable;
        private Button BtnUpdateTable;
        private Button BtnDeleteTable;
    }
}