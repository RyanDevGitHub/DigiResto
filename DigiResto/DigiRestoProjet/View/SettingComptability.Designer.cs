namespace DigiRestoProjet.View
{
    partial class SettingComptability
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
            this.BtnStatCa = new System.Windows.Forms.Button();
            this.BtnStatArticle = new System.Windows.Forms.Button();
            this.BtnHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Setting Comptability";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(17, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 10);
            this.panel1.TabIndex = 1;
            // 
            // BtnStatCa
            // 
            this.BtnStatCa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnStatCa.Location = new System.Drawing.Point(53, 122);
            this.BtnStatCa.Name = "BtnStatCa";
            this.BtnStatCa.Size = new System.Drawing.Size(238, 84);
            this.BtnStatCa.TabIndex = 2;
            this.BtnStatCa.Text = "Statistique CA";
            this.BtnStatCa.UseVisualStyleBackColor = true;
            this.BtnStatCa.Click += new System.EventHandler(this.BtnStatCa_Click);
            // 
            // BtnStatArticle
            // 
            this.BtnStatArticle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnStatArticle.Location = new System.Drawing.Point(53, 223);
            this.BtnStatArticle.Name = "BtnStatArticle";
            this.BtnStatArticle.Size = new System.Drawing.Size(238, 84);
            this.BtnStatArticle.TabIndex = 3;
            this.BtnStatArticle.Text = "Statistique Article";
            this.BtnStatArticle.UseVisualStyleBackColor = true;
            this.BtnStatArticle.Click += new System.EventHandler(this.BtnStatArticle_Click);
            // 
            // BtnHistory
            // 
            this.BtnHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnHistory.Location = new System.Drawing.Point(53, 322);
            this.BtnHistory.Name = "BtnHistory";
            this.BtnHistory.Size = new System.Drawing.Size(238, 84);
            this.BtnHistory.TabIndex = 4;
            this.BtnHistory.Text = "History";
            this.BtnHistory.UseVisualStyleBackColor = true;
            this.BtnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
            // 
            // SettingComptability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 534);
            this.Controls.Add(this.BtnHistory);
            this.Controls.Add(this.BtnStatArticle);
            this.Controls.Add(this.BtnStatCa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SettingComptability";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingComptability";
            this.Load += new System.EventHandler(this.SettingComptability_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button BtnStatCa;
        private Button BtnStatArticle;
        private Button BtnHistory;
    }
}