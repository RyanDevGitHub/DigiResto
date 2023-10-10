namespace Projet_Pi_DIGIRESTO.View
{
    partial class UpdateStockPage
    {
        public int index;
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
            this.UpdateStockTextBox1 = new System.Windows.Forms.TextBox();
            this.BtnUpdateStock = new System.Windows.Forms.Button();
            this.UpdateStockDateTime = new System.Windows.Forms.DateTimePicker();
            this.QuantityTextBox3 = new System.Windows.Forms.TextBox();
            this.UpdateStockcomboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(85, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Stock";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(36, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 18);
            this.panel1.TabIndex = 2;
            // 
            // UpdateStockTextBox1
            // 
            this.UpdateStockTextBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateStockTextBox1.Location = new System.Drawing.Point(75, 150);
            this.UpdateStockTextBox1.Name = "UpdateStockTextBox1";
            this.UpdateStockTextBox1.Size = new System.Drawing.Size(253, 33);
            this.UpdateStockTextBox1.TabIndex = 3;
            // 
            // BtnUpdateStock
            // 
            this.BtnUpdateStock.BackColor = System.Drawing.Color.Chartreuse;
            this.BtnUpdateStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateStock.Location = new System.Drawing.Point(286, 499);
            this.BtnUpdateStock.Name = "BtnUpdateStock";
            this.BtnUpdateStock.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdateStock.TabIndex = 4;
            this.BtnUpdateStock.Text = "Update";
            this.BtnUpdateStock.UseVisualStyleBackColor = false;
            this.BtnUpdateStock.Click += new System.EventHandler(this.BtnUpdateStock_Click);
            // 
            // UpdateStockDateTime
            // 
            this.UpdateStockDateTime.Location = new System.Drawing.Point(75, 229);
            this.UpdateStockDateTime.Name = "UpdateStockDateTime";
            this.UpdateStockDateTime.Size = new System.Drawing.Size(253, 23);
            this.UpdateStockDateTime.TabIndex = 5;
            // 
            // QuantityTextBox3
            // 
            this.QuantityTextBox3.Location = new System.Drawing.Point(131, 334);
            this.QuantityTextBox3.Name = "QuantityTextBox3";
            this.QuantityTextBox3.Size = new System.Drawing.Size(47, 23);
            this.QuantityTextBox3.TabIndex = 7;
            // 
            // UpdateStockcomboBox1
            // 
            this.UpdateStockcomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UpdateStockcomboBox1.FormattingEnabled = true;
            this.UpdateStockcomboBox1.Location = new System.Drawing.Point(184, 334);
            this.UpdateStockcomboBox1.Name = "UpdateStockcomboBox1";
            this.UpdateStockcomboBox1.Size = new System.Drawing.Size(121, 23);
            this.UpdateStockcomboBox1.TabIndex = 8;
            this.UpdateStockcomboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // UpdateStockPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 554);
            this.Controls.Add(this.UpdateStockcomboBox1);
            this.Controls.Add(this.QuantityTextBox3);
            this.Controls.Add(this.UpdateStockDateTime);
            this.Controls.Add(this.BtnUpdateStock);
            this.Controls.Add(this.UpdateStockTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UpdateStockPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStockPage";
            this.Load += new System.EventHandler(this.UpdateStockPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        public TextBox UpdateStockTextBox1;
        private Button BtnUpdateStock;
        public DateTimePicker UpdateStockDateTime;
        public TextBox QuantityTextBox3;
        public ComboBox UpdateStockcomboBox1;
    }


}
       

