namespace Projet_Pi_DIGIRESTO.View
{
    public partial class AddStockPage
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
            this.NameStockTextBox = new System.Windows.Forms.TextBox();
            this.BtnAddStock = new System.Windows.Forms.Button();
            this.StockPeremptiondateTime = new System.Windows.Forms.DateTimePicker();
            this.StockQuantityBox = new System.Windows.Forms.TextBox();
            this.UnitsComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(103, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Stock";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(36, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 18);
            this.panel1.TabIndex = 2;
            // 
            // NameStockTextBox
            // 
            this.NameStockTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameStockTextBox.Location = new System.Drawing.Point(75, 150);
            this.NameStockTextBox.Name = "NameStockTextBox";
            this.NameStockTextBox.Size = new System.Drawing.Size(253, 33);
            this.NameStockTextBox.TabIndex = 3;
            this.NameStockTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BtnAddStock
            // 
            this.BtnAddStock.BackColor = System.Drawing.Color.Chartreuse;
            this.BtnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddStock.Location = new System.Drawing.Point(286, 499);
            this.BtnAddStock.Name = "BtnAddStock";
            this.BtnAddStock.Size = new System.Drawing.Size(75, 23);
            this.BtnAddStock.TabIndex = 4;
            this.BtnAddStock.Text = "Add";
            this.BtnAddStock.UseVisualStyleBackColor = false;
            this.BtnAddStock.Click += new System.EventHandler(this.BtnAddStock_Click);
            // 
            // StockPeremptiondateTime
            // 
            this.StockPeremptiondateTime.Location = new System.Drawing.Point(75, 229);
            this.StockPeremptiondateTime.Name = "StockPeremptiondateTime";
            this.StockPeremptiondateTime.Size = new System.Drawing.Size(253, 23);
            this.StockPeremptiondateTime.TabIndex = 5;
            // 
            // StockQuantityBox
            // 
            this.StockQuantityBox.Location = new System.Drawing.Point(131, 334);
            this.StockQuantityBox.Name = "StockQuantityBox";
            this.StockQuantityBox.Size = new System.Drawing.Size(47, 23);
            this.StockQuantityBox.TabIndex = 7;
            // 
            // UnitsComboBox
            // 
            this.UnitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnitsComboBox.FormattingEnabled = true;
            this.UnitsComboBox.Location = new System.Drawing.Point(184, 334);
            this.UnitsComboBox.Name = "UnitsComboBox";
            this.UnitsComboBox.Size = new System.Drawing.Size(121, 23);
            this.UnitsComboBox.TabIndex = 8;
            this.UnitsComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AddStockPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 554);
            this.Controls.Add(this.UnitsComboBox);
            this.Controls.Add(this.StockQuantityBox);
            this.Controls.Add(this.StockPeremptiondateTime);
            this.Controls.Add(this.BtnAddStock);
            this.Controls.Add(this.NameStockTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddStockPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStockPage";
            this.Load += new System.EventHandler(this.AddStockPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox NameStockTextBox;
        private Button BtnAddStock;
        private DateTimePicker StockPeremptiondateTime;
        private TextBox StockQuantityBox;
        private ComboBox UnitsComboBox;
    }
}