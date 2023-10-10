using DigiRestoProjet.Model;
using DigiRestoProjet.Controller;
using DigiRestoProjet.Model;
using DigiRestoProjet.View.ManagePage;
using Projet_Pi_DIGIRESTO.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiRestoProjet.View
{
    partial class CardUserControl1 : UserControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnOrderInProgress = new System.Windows.Forms.Button();
            this.btnResetCommand = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvBill = new System.Windows.Forms.ListView();
            this.ArticleId = new System.Windows.Forms.ColumnHeader();
            this.ItemName = new System.Windows.Forms.ColumnHeader();
            this.Quantity = new System.Windows.Forms.ColumnHeader();
            this.Total = new System.Windows.Forms.ColumnHeader();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TblDisplayArticle = new System.Windows.Forms.TableLayoutPanel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnNum0 = new System.Windows.Forms.Button();
            this.BtnNum1 = new System.Windows.Forms.Button();
            this.BtnNum2 = new System.Windows.Forms.Button();
            this.BtnNum3 = new System.Windows.Forms.Button();
            this.BtnNum4 = new System.Windows.Forms.Button();
            this.BtnNum5 = new System.Windows.Forms.Button();
            this.BtnNum6 = new System.Windows.Forms.Button();
            this.BtnNum7 = new System.Windows.Forms.Button();
            this.BtnNum8 = new System.Windows.Forms.Button();
            this.BtnNum9 = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.BtnSaveOrder = new System.Windows.Forms.Button();
            this.BtnTakeAway = new System.Windows.Forms.Button();
            this.BtnOnSite = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.760001F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.48F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.76F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel10, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.631435F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.36856F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1212, 627);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tableLayoutPanel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(118, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 41);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.tableLayoutPanel5.ColumnCount = 8;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.32806F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.09486F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.533597F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.050847F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.37288F));
            this.tableLayoutPanel5.Controls.Add(this.BtnSettings, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.BtnOrderInProgress, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnResetCommand, 7, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.43243F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(708, 41);
            this.tableLayoutPanel5.TabIndex = 0;
            this.tableLayoutPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel5_Paint);
            // 
            // BtnSettings
            // 
            this.BtnSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSettings.Location = new System.Drawing.Point(3, 3);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(95, 35);
            this.BtnSettings.TabIndex = 0;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // BtnOrderInProgress
            // 
            this.BtnOrderInProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnOrderInProgress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnOrderInProgress.Location = new System.Drawing.Point(105, 5);
            this.BtnOrderInProgress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnOrderInProgress.Name = "BtnOrderInProgress";
            this.BtnOrderInProgress.Size = new System.Drawing.Size(113, 31);
            this.BtnOrderInProgress.TabIndex = 1;
            this.BtnOrderInProgress.Text = "OrderInProgress";
            this.BtnOrderInProgress.UseVisualStyleBackColor = true;
            this.BtnOrderInProgress.Click += new System.EventHandler(this.BtnOrderInProgress_Click);
            // 
            // btnResetCommand
            // 
            this.btnResetCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnResetCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResetCommand.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnResetCommand.Location = new System.Drawing.Point(585, 3);
            this.btnResetCommand.Name = "btnResetCommand";
            this.btnResetCommand.Size = new System.Drawing.Size(120, 35);
            this.btnResetCommand.TabIndex = 9;
            this.btnResetCommand.Text = "New Order";
            this.btnResetCommand.UseVisualStyleBackColor = false;
            this.btnResetCommand.Click += new System.EventHandler(this.btnResetCommand_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(82)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.tableLayoutPanel1.SetRowSpan(this.panel2, 4);
            this.panel2.Size = new System.Drawing.Size(118, 627);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lvBill);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(826, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.tableLayoutPanel1.SetRowSpan(this.panel3, 2);
            this.panel3.Size = new System.Drawing.Size(386, 312);
            this.panel3.TabIndex = 2;
            // 
            // lvBill
            // 
            this.lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ArticleId,
            this.ItemName,
            this.Quantity,
            this.Total});
            this.lvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBill.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvBill.FullRowSelect = true;
            this.lvBill.GridLines = true;
            this.lvBill.Location = new System.Drawing.Point(0, 0);
            this.lvBill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvBill.Name = "lvBill";
            this.lvBill.Size = new System.Drawing.Size(386, 312);
            this.lvBill.TabIndex = 0;
            this.lvBill.UseCompatibleStateImageBehavior = false;
            this.lvBill.View = System.Windows.Forms.View.Details;
            this.lvBill.SelectedIndexChanged += new System.EventHandler(this.lvBill_SelectedIndexChanged);
            // 
            // ArticleId
            // 
            this.ArticleId.Text = "Article ID";
            // 
            // ItemName
            // 
            this.ItemName.Text = "Item Name";
            this.ItemName.Width = 200;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 80;
            // 
            // Total
            // 
            this.Total.Text = "Total";
            this.Total.Width = 150;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.panel4.Controls.Add(this.TblDisplayArticle);
            this.panel4.Controls.Add(this.panel12);
            this.panel4.Controls.Add(this.panel11);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(118, 41);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.tableLayoutPanel1.SetRowSpan(this.panel4, 3);
            this.panel4.Size = new System.Drawing.Size(708, 586);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // TblDisplayArticle
            // 
            this.TblDisplayArticle.ColumnCount = 5;
            this.TblDisplayArticle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TblDisplayArticle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TblDisplayArticle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TblDisplayArticle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TblDisplayArticle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TblDisplayArticle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblDisplayArticle.Location = new System.Drawing.Point(38, 29);
            this.TblDisplayArticle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TblDisplayArticle.Name = "TblDisplayArticle";
            this.TblDisplayArticle.RowCount = 5;
            this.TblDisplayArticle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TblDisplayArticle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TblDisplayArticle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TblDisplayArticle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TblDisplayArticle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TblDisplayArticle.Size = new System.Drawing.Size(634, 532);
            this.TblDisplayArticle.TabIndex = 5;
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(38, 561);
            this.panel12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(634, 25);
            this.panel12.TabIndex = 4;
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(38, 0);
            this.panel11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(634, 29);
            this.panel11.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(672, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(36, 586);
            this.panel8.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(38, 586);
            this.panel7.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.panel9.Controls.Add(this.tableLayoutPanel4);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(826, 312);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panel9.Size = new System.Drawing.Size(386, 156);
            this.panel9.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.Controls.Add(this.BtnNum0, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.BtnNum1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.BtnNum2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.BtnNum3, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.BtnNum4, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.BtnNum5, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.BtnNum6, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.BtnNum7, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.BtnNum8, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.BtnNum9, 2, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(21, 8);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(375, 145);
            this.tableLayoutPanel4.TabIndex = 0;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // BtnNum0
            // 
            this.BtnNum0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNum0.Location = new System.Drawing.Point(128, 113);
            this.BtnNum0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNum0.Name = "BtnNum0";
            this.BtnNum0.Size = new System.Drawing.Size(117, 27);
            this.BtnNum0.TabIndex = 0;
            this.BtnNum0.Text = "0";
            this.BtnNum0.UseVisualStyleBackColor = true;
            // 
            // BtnNum1
            // 
            this.BtnNum1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNum1.Location = new System.Drawing.Point(3, 3);
            this.BtnNum1.Name = "BtnNum1";
            this.BtnNum1.Size = new System.Drawing.Size(118, 30);
            this.BtnNum1.TabIndex = 0;
            this.BtnNum1.Text = "1";
            this.BtnNum1.UseVisualStyleBackColor = true;
            // 
            // BtnNum2
            // 
            this.BtnNum2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNum2.Location = new System.Drawing.Point(128, 5);
            this.BtnNum2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNum2.Name = "BtnNum2";
            this.BtnNum2.Size = new System.Drawing.Size(117, 26);
            this.BtnNum2.TabIndex = 1;
            this.BtnNum2.Text = "2";
            this.BtnNum2.UseVisualStyleBackColor = true;
            // 
            // BtnNum3
            // 
            this.BtnNum3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNum3.Location = new System.Drawing.Point(253, 5);
            this.BtnNum3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNum3.Name = "BtnNum3";
            this.BtnNum3.Size = new System.Drawing.Size(118, 26);
            this.BtnNum3.TabIndex = 2;
            this.BtnNum3.Text = "3";
            this.BtnNum3.UseVisualStyleBackColor = true;
            // 
            // BtnNum4
            // 
            this.BtnNum4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNum4.Location = new System.Drawing.Point(4, 41);
            this.BtnNum4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNum4.Name = "BtnNum4";
            this.BtnNum4.Size = new System.Drawing.Size(116, 26);
            this.BtnNum4.TabIndex = 3;
            this.BtnNum4.Text = "4";
            this.BtnNum4.UseVisualStyleBackColor = true;
            // 
            // BtnNum5
            // 
            this.BtnNum5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNum5.Location = new System.Drawing.Point(128, 41);
            this.BtnNum5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNum5.Name = "BtnNum5";
            this.BtnNum5.Size = new System.Drawing.Size(117, 26);
            this.BtnNum5.TabIndex = 4;
            this.BtnNum5.Text = "5";
            this.BtnNum5.UseVisualStyleBackColor = true;
            // 
            // BtnNum6
            // 
            this.BtnNum6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNum6.Location = new System.Drawing.Point(253, 41);
            this.BtnNum6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNum6.Name = "BtnNum6";
            this.BtnNum6.Size = new System.Drawing.Size(118, 26);
            this.BtnNum6.TabIndex = 5;
            this.BtnNum6.Text = "6";
            this.BtnNum6.UseVisualStyleBackColor = true;
            // 
            // BtnNum7
            // 
            this.BtnNum7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNum7.Location = new System.Drawing.Point(4, 77);
            this.BtnNum7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNum7.Name = "BtnNum7";
            this.BtnNum7.Size = new System.Drawing.Size(116, 26);
            this.BtnNum7.TabIndex = 6;
            this.BtnNum7.Text = "7";
            this.BtnNum7.UseVisualStyleBackColor = true;
            // 
            // BtnNum8
            // 
            this.BtnNum8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNum8.Location = new System.Drawing.Point(128, 77);
            this.BtnNum8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNum8.Name = "BtnNum8";
            this.BtnNum8.Size = new System.Drawing.Size(117, 26);
            this.BtnNum8.TabIndex = 7;
            this.BtnNum8.Text = "8";
            this.BtnNum8.UseVisualStyleBackColor = true;
            // 
            // BtnNum9
            // 
            this.BtnNum9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNum9.Location = new System.Drawing.Point(253, 77);
            this.BtnNum9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNum9.Name = "BtnNum9";
            this.BtnNum9.Size = new System.Drawing.Size(118, 26);
            this.BtnNum9.TabIndex = 8;
            this.BtnNum9.Text = "9";
            this.BtnNum9.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.panel10.Controls.Add(this.BtnSaveOrder);
            this.panel10.Controls.Add(this.BtnTakeAway);
            this.panel10.Controls.Add(this.BtnOnSite);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(826, 468);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(386, 159);
            this.panel10.TabIndex = 5;
            // 
            // BtnSaveOrder
            // 
            this.BtnSaveOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSaveOrder.Location = new System.Drawing.Point(258, 66);
            this.BtnSaveOrder.Name = "BtnSaveOrder";
            this.BtnSaveOrder.Size = new System.Drawing.Size(119, 62);
            this.BtnSaveOrder.TabIndex = 2;
            this.BtnSaveOrder.Text = "Save";
            this.BtnSaveOrder.UseVisualStyleBackColor = true;
            this.BtnSaveOrder.Click += new System.EventHandler(this.BtnSaveOrder_Click);
            // 
            // BtnTakeAway
            // 
            this.BtnTakeAway.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnTakeAway.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnTakeAway.Location = new System.Drawing.Point(130, 74);
            this.BtnTakeAway.Name = "BtnTakeAway";
            this.BtnTakeAway.Size = new System.Drawing.Size(80, 35);
            this.BtnTakeAway.TabIndex = 1;
            this.BtnTakeAway.Text = "Take Away";
            this.BtnTakeAway.UseVisualStyleBackColor = false;
            this.BtnTakeAway.Click += new System.EventHandler(this.BtnTakeAway_Click);
            // 
            // BtnOnSite
            // 
            this.BtnOnSite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnOnSite.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnOnSite.Location = new System.Drawing.Point(38, 74);
            this.BtnOnSite.Name = "BtnOnSite";
            this.BtnOnSite.Size = new System.Drawing.Size(85, 35);
            this.BtnOnSite.TabIndex = 0;
            this.BtnOnSite.Text = "On Site";
            this.BtnOnSite.UseVisualStyleBackColor = false;
            this.BtnOnSite.Click += new System.EventHandler(this.BtnOnSite_Click);
            // 
            // CardUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(222)))), ((int)(((byte)(156)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CardUserControl1";
            this.Size = new System.Drawing.Size(1212, 627);
            this.Load += new System.EventHandler(this.CardUserControl1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        public Panel panel2;
        public static Panel globalPanel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel9;
        private Panel panel10;
        private Button BtnSaveOrder;
        private Button BtnTakeAway;
        private Button BtnOnSite;
        private TableLayoutPanel tableLayoutPanel4;
        private Button BtnNum0;
        private Button BtnNum1;
        private Button BtnNum2;
        private Button BtnNum3;
        private Button BtnNum4;
        private Button BtnNum5;
        private Button BtnNum6;
        private Button BtnNum7;
        private Button BtnNum8;
        private Button BtnNum9;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel5;
        private Panel panel6;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel5;
        private Button BtnSettings;
        private Button BtnOrderInProgress;
        public ListView lvBill;
        private ColumnHeader ItemName;
        private ColumnHeader Quantity;
        private ColumnHeader Total;
        private ColumnHeader ArticleId;
        private Panel panel8;
        private Panel panel7;
        private Panel panel12;
        private Panel panel11;
        public TableLayoutPanel TblDisplayArticle;
        private Button btnResetCommand;
    }
}
