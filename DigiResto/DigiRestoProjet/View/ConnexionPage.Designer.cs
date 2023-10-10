namespace DigiRestoProjet.View
{
    partial class ConnexionPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.flpShowManager = new System.Windows.Forms.FlowLayoutPanel();
            this.Manager = new System.Windows.Forms.Label();
            this.clbShowEmployee = new System.Windows.Forms.CheckedListBox();
            this.tbnDone = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 63);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(196, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONNEXION";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flpShowManager, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Manager, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.clbShowEmployee, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 81);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.98058F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.01942F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(550, 517);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(278, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 72);
            this.label2.TabIndex = 6;
            this.label2.Text = "Employers";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpShowManager
            // 
            this.flpShowManager.AutoScroll = true;
            this.flpShowManager.BackColor = System.Drawing.Color.Linen;
            this.flpShowManager.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpShowManager.Location = new System.Drawing.Point(3, 75);
            this.flpShowManager.Name = "flpShowManager";
            this.flpShowManager.Size = new System.Drawing.Size(269, 424);
            this.flpShowManager.TabIndex = 3;
            this.flpShowManager.Paint += new System.Windows.Forms.PaintEventHandler(this.flpShowManager_Paint);
            // 
            // Manager
            // 
            this.Manager.AutoSize = true;
            this.Manager.BackColor = System.Drawing.Color.SteelBlue;
            this.Manager.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Manager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Manager.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Manager.Location = new System.Drawing.Point(3, 0);
            this.Manager.Name = "Manager";
            this.Manager.Size = new System.Drawing.Size(269, 72);
            this.Manager.TabIndex = 5;
            this.Manager.Text = "Managers";
            this.Manager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clbShowEmployee
            // 
            this.clbShowEmployee.BackColor = System.Drawing.Color.Linen;
            this.clbShowEmployee.FormattingEnabled = true;
            this.clbShowEmployee.Location = new System.Drawing.Point(278, 75);
            this.clbShowEmployee.Name = "clbShowEmployee";
            this.clbShowEmployee.Size = new System.Drawing.Size(269, 424);
            this.clbShowEmployee.TabIndex = 7;
            // 
            // tbnDone
            // 
            this.tbnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbnDone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbnDone.Location = new System.Drawing.Point(447, 595);
            this.tbnDone.Name = "tbnDone";
            this.tbnDone.Size = new System.Drawing.Size(112, 71);
            this.tbnDone.TabIndex = 3;
            this.tbnDone.Text = "Done";
            this.tbnDone.UseVisualStyleBackColor = false;
            this.tbnDone.Click += new System.EventHandler(this.tbnDone_Click);
            // 
            // ConnexionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(578, 687);
            this.Controls.Add(this.tbnDone);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "ConnexionPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flpShowManager;
        private Button tbnDone;
        private Label label2;
        private Label Manager;
        private CheckedListBox clbShowEmployee;
    }
}