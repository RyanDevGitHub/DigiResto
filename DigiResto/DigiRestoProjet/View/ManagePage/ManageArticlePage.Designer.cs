namespace DigiRestoProjet.View
{
    partial class ManageArticlePage
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
            this.LabManageArticle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxArticle = new System.Windows.Forms.ComboBox();
            this.BtnAddArticle = new System.Windows.Forms.Button();
            this.BtnUpdateArticle = new System.Windows.Forms.Button();
            this.BtnDeleteArticle = new System.Windows.Forms.Button();
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
            // LabManageArticle
            // 
            this.LabManageArticle.AutoSize = true;
            this.LabManageArticle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabManageArticle.Location = new System.Drawing.Point(79, 22);
            this.LabManageArticle.Name = "LabManageArticle";
            this.LabManageArticle.Size = new System.Drawing.Size(249, 45);
            this.LabManageArticle.TabIndex = 2;
            this.LabManageArticle.Text = "Manage Article";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "select the Article you want to edit or modify";
            // 
            // comboBoxArticle
            // 
            this.comboBoxArticle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxArticle.FormattingEnabled = true;
            this.comboBoxArticle.Location = new System.Drawing.Point(39, 205);
            this.comboBoxArticle.Name = "comboBoxArticle";
            this.comboBoxArticle.Size = new System.Drawing.Size(228, 23);
            this.comboBoxArticle.TabIndex = 6;
            // 
            // BtnAddArticle
            // 
            this.BtnAddArticle.Location = new System.Drawing.Point(138, 489);
            this.BtnAddArticle.Name = "BtnAddArticle";
            this.BtnAddArticle.Size = new System.Drawing.Size(114, 31);
            this.BtnAddArticle.TabIndex = 7;
            this.BtnAddArticle.Text = "Add Article";
            this.BtnAddArticle.UseVisualStyleBackColor = true;
            this.BtnAddArticle.Click += new System.EventHandler(this.BtnAddArticle_Click);
            // 
            // BtnUpdateArticle
            // 
            this.BtnUpdateArticle.Location = new System.Drawing.Point(295, 205);
            this.BtnUpdateArticle.Name = "BtnUpdateArticle";
            this.BtnUpdateArticle.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdateArticle.TabIndex = 8;
            this.BtnUpdateArticle.Text = "Update";
            this.BtnUpdateArticle.UseVisualStyleBackColor = true;
            this.BtnUpdateArticle.Click += new System.EventHandler(this.BtnUpdateArticle_Click);
            // 
            // BtnDeleteArticle
            // 
            this.BtnDeleteArticle.Location = new System.Drawing.Point(295, 249);
            this.BtnDeleteArticle.Name = "BtnDeleteArticle";
            this.BtnDeleteArticle.Size = new System.Drawing.Size(75, 23);
            this.BtnDeleteArticle.TabIndex = 9;
            this.BtnDeleteArticle.Text = "Delete";
            this.BtnDeleteArticle.UseVisualStyleBackColor = true;
            this.BtnDeleteArticle.Click += new System.EventHandler(this.BtnDeleteArticle_Click);
            // 
            // ManageArticlePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 554);
            this.Controls.Add(this.BtnDeleteArticle);
            this.Controls.Add(this.BtnUpdateArticle);
            this.Controls.Add(this.BtnAddArticle);
            this.Controls.Add(this.comboBoxArticle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabManageArticle);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManageArticlePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCategoryPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    #endregion

    private Panel panel1;
    private Label LabManageArticle;
    private Label label1;
    private ComboBox comboBoxArticle;
    private Button BtnAddArticle;
    private Button BtnUpdateArticle;
    private Button BtnDeleteArticle;
}

}