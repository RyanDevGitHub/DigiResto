namespace Projet_Pi_DIGIRESTO.View
{
    partial class SettingsPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnStockSettings = new System.Windows.Forms.Button();
            this.BtnSettingTable = new System.Windows.Forms.Button();
            this.BtnSettingsCategory = new System.Windows.Forms.Button();
            this.BtnSettingComptability = new System.Windows.Forms.Button();
            this.BtnSettingUser = new System.Windows.Forms.Button();
            this.BtnSettingMenu = new System.Windows.Forms.Button();
            this.BtnArticle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(130, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(35, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 18);
            this.panel1.TabIndex = 1;
            // 
            // BtnStockSettings
            // 
            this.BtnStockSettings.Location = new System.Drawing.Point(60, 111);
            this.BtnStockSettings.Name = "BtnStockSettings";
            this.BtnStockSettings.Size = new System.Drawing.Size(280, 45);
            this.BtnStockSettings.TabIndex = 2;
            this.BtnStockSettings.Text = "Stock";
            this.BtnStockSettings.UseVisualStyleBackColor = true;
            this.BtnStockSettings.Click += new System.EventHandler(this.BtnStockSettings_Click);
            // 
            // BtnSettingTable
            // 
            this.BtnSettingTable.Location = new System.Drawing.Point(60, 170);
            this.BtnSettingTable.Name = "BtnSettingTable";
            this.BtnSettingTable.Size = new System.Drawing.Size(280, 45);
            this.BtnSettingTable.TabIndex = 3;
            this.BtnSettingTable.Text = "Table";
            this.BtnSettingTable.UseVisualStyleBackColor = true;
            this.BtnSettingTable.Click += new System.EventHandler(this.BtnSettingTable_Click);
            // 
            // BtnSettingsCategory
            // 
            this.BtnSettingsCategory.Location = new System.Drawing.Point(60, 288);
            this.BtnSettingsCategory.Name = "BtnSettingsCategory";
            this.BtnSettingsCategory.Size = new System.Drawing.Size(280, 45);
            this.BtnSettingsCategory.TabIndex = 4;
            this.BtnSettingsCategory.Text = "Category";
            this.BtnSettingsCategory.UseVisualStyleBackColor = true;
            this.BtnSettingsCategory.Click += new System.EventHandler(this.BtnSettingsCategory_Click);
            // 
            // BtnSettingComptability
            // 
            this.BtnSettingComptability.Location = new System.Drawing.Point(60, 406);
            this.BtnSettingComptability.Name = "BtnSettingComptability";
            this.BtnSettingComptability.Size = new System.Drawing.Size(280, 45);
            this.BtnSettingComptability.TabIndex = 5;
            this.BtnSettingComptability.Text = "Comptability";
            this.BtnSettingComptability.UseVisualStyleBackColor = true;
            this.BtnSettingComptability.Click += new System.EventHandler(this.BtnSettingComptability_Click);
            // 
            // BtnSettingUser
            // 
            this.BtnSettingUser.Location = new System.Drawing.Point(60, 465);
            this.BtnSettingUser.Name = "BtnSettingUser";
            this.BtnSettingUser.Size = new System.Drawing.Size(280, 45);
            this.BtnSettingUser.TabIndex = 7;
            this.BtnSettingUser.Text = "User";
            this.BtnSettingUser.UseVisualStyleBackColor = true;
            this.BtnSettingUser.Click += new System.EventHandler(this.BtnSettingUser_Click);
            // 
            // BtnSettingMenu
            // 
            this.BtnSettingMenu.Location = new System.Drawing.Point(60, 347);
            this.BtnSettingMenu.Name = "BtnSettingMenu";
            this.BtnSettingMenu.Size = new System.Drawing.Size(280, 45);
            this.BtnSettingMenu.TabIndex = 8;
            this.BtnSettingMenu.Text = "Menu";
            this.BtnSettingMenu.UseVisualStyleBackColor = true;
            this.BtnSettingMenu.Click += new System.EventHandler(this.BtnSettingMenu_Click);
            // 
            // BtnArticle
            // 
            this.BtnArticle.Location = new System.Drawing.Point(60, 229);
            this.BtnArticle.Name = "BtnArticle";
            this.BtnArticle.Size = new System.Drawing.Size(280, 45);
            this.BtnArticle.TabIndex = 9;
            this.BtnArticle.Text = "Article";
            this.BtnArticle.UseVisualStyleBackColor = true;
            this.BtnArticle.Click += new System.EventHandler(this.BtnArticle_Click);
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 539);
            this.Controls.Add(this.BtnArticle);
            this.Controls.Add(this.BtnSettingMenu);
            this.Controls.Add(this.BtnSettingUser);
            this.Controls.Add(this.BtnSettingComptability);
            this.Controls.Add(this.BtnSettingsCategory);
            this.Controls.Add(this.BtnSettingTable);
            this.Controls.Add(this.BtnStockSettings);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SettingsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsPage";
            this.Load += new System.EventHandler(this.SettingsPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button BtnStockSettings;
        private Button BtnSettingTable;
        private Button BtnSettingsCategory;
        private Button BtnSettingComptability;
        private Button BtnSettingUser;
        private Button BtnSettingMenu;
        private Button BtnArticle;
    }
}