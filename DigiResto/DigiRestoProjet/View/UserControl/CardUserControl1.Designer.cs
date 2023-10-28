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
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(CardUserControl1));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            BtnSettings = new Button();
            imageList1 = new ImageList(components);
            btnResetCommand = new Button();
            BtnOrderInProgress = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            lvBill = new ListView();
            ArticleId = new ColumnHeader();
            ItemName = new ColumnHeader();
            Quantity = new ColumnHeader();
            Total = new ColumnHeader();
            panel4 = new Panel();
            TblDisplayArticle = new TableLayoutPanel();
            panel12 = new Panel();
            panel11 = new Panel();
            panel8 = new Panel();
            panel7 = new Panel();
            panel9 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            BtnNum0 = new Button();
            BtnNum1 = new Button();
            BtnNum2 = new Button();
            BtnNum3 = new Button();
            BtnNum4 = new Button();
            BtnNum5 = new Button();
            BtnNum6 = new Button();
            BtnNum7 = new Button();
            BtnNum8 = new Button();
            BtnNum9 = new Button();
            panel10 = new Panel();
            BtnSaveOrder = new Button();
            BtnTakeAway = new Button();
            BtnOnSite = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel9.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.760001F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.48F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.76F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 2, 0);
            tableLayoutPanel1.Controls.Add(panel4, 1, 1);
            tableLayoutPanel1.Controls.Add(panel9, 2, 2);
            tableLayoutPanel1.Controls.Add(panel10, 2, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.631435F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 43.36856F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(1212, 627);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tableLayoutPanel5);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(118, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(708, 41);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = Color.FromArgb(34, 87, 122);
            tableLayoutPanel5.ColumnCount = 8;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.32806F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.09486F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.533597F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.050847F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.37288F));
            tableLayoutPanel5.Controls.Add(BtnSettings, 0, 0);
            tableLayoutPanel5.Controls.Add(btnResetCommand, 7, 0);
            tableLayoutPanel5.Controls.Add(BtnOrderInProgress, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 32.43243F));
            tableLayoutPanel5.Size = new Size(708, 41);
            tableLayoutPanel5.TabIndex = 0;
            tableLayoutPanel5.Paint += tableLayoutPanel5_Paint;
            // 
            // BtnSettings
            // 
            BtnSettings.Dock = DockStyle.Fill;
            BtnSettings.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSettings.ImageIndex = 4;
            BtnSettings.ImageList = imageList1;
            BtnSettings.Location = new Point(3, 3);
            BtnSettings.Name = "BtnSettings";
            BtnSettings.Size = new Size(95, 35);
            BtnSettings.TabIndex = 0;
            BtnSettings.UseVisualStyleBackColor = true;
            BtnSettings.Click += BtnSettings_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-boisson-100.png");
            imageList1.Images.SetKeyName(1, "icons8-boisson-chaude-100.png");
            imageList1.Images.SetKeyName(2, "icons8-burger-100.png");
            imageList1.Images.SetKeyName(3, "icons8-dessert-100.png");
            imageList1.Images.SetKeyName(4, "icons8-paramètres-240.png");
            imageList1.Images.SetKeyName(5, "icons8-plat-100.png");
            imageList1.Images.SetKeyName(6, "icons8-salade-100.png");
            imageList1.Images.SetKeyName(7, "icons8-sauvegarder-100.png");
            imageList1.Images.SetKeyName(8, "icons8-table-100.png");
            imageList1.Images.SetKeyName(9, "icons8-nourriture-à-emporter-100.png");
            // 
            // btnResetCommand
            // 
            btnResetCommand.BackColor = Color.FromArgb(255, 128, 0);
            btnResetCommand.Dock = DockStyle.Fill;
            btnResetCommand.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnResetCommand.Location = new Point(585, 3);
            btnResetCommand.Name = "btnResetCommand";
            btnResetCommand.Size = new Size(120, 35);
            btnResetCommand.TabIndex = 9;
            btnResetCommand.Text = "New Order";
            btnResetCommand.UseVisualStyleBackColor = false;
            btnResetCommand.Click += btnResetCommand_Click;
            // 
            // BtnOrderInProgress
            // 
            BtnOrderInProgress.Dock = DockStyle.Fill;
            BtnOrderInProgress.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnOrderInProgress.Location = new Point(105, 5);
            BtnOrderInProgress.Margin = new Padding(4, 5, 4, 5);
            BtnOrderInProgress.Name = "BtnOrderInProgress";
            BtnOrderInProgress.Size = new Size(113, 31);
            BtnOrderInProgress.TabIndex = 1;
            BtnOrderInProgress.Text = "OrderInProgress";
            BtnOrderInProgress.UseVisualStyleBackColor = true;
            BtnOrderInProgress.Click += BtnOrderInProgress_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 165, 82);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            tableLayoutPanel1.SetRowSpan(panel2, 4);
            panel2.Size = new Size(118, 627);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lvBill);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(826, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            tableLayoutPanel1.SetRowSpan(panel3, 2);
            panel3.Size = new Size(386, 312);
            panel3.TabIndex = 2;
            // 
            // lvBill
            // 
            lvBill.Columns.AddRange(new ColumnHeader[] { ArticleId, ItemName, Quantity, Total });
            lvBill.Dock = DockStyle.Fill;
            lvBill.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lvBill.FullRowSelect = true;
            lvBill.GridLines = true;
            lvBill.Location = new Point(0, 0);
            lvBill.Margin = new Padding(2);
            lvBill.Name = "lvBill";
            lvBill.Size = new Size(386, 312);
            lvBill.TabIndex = 0;
            lvBill.UseCompatibleStateImageBehavior = false;
            lvBill.View = System.Windows.Forms.View.Details;
            lvBill.SelectedIndexChanged += lvBill_SelectedIndexChanged;
            // 
            // ArticleId
            // 
            ArticleId.Text = "Article ID";
            // 
            // ItemName
            // 
            ItemName.Text = "Item Name";
            ItemName.Width = 200;
            // 
            // Quantity
            // 
            Quantity.Text = "Quantity";
            Quantity.Width = 80;
            // 
            // Total
            // 
            Total.Text = "Total";
            Total.Width = 150;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(34, 87, 122);
            panel4.Controls.Add(TblDisplayArticle);
            panel4.Controls.Add(panel12);
            panel4.Controls.Add(panel11);
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(panel7);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(118, 41);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            tableLayoutPanel1.SetRowSpan(panel4, 3);
            panel4.Size = new Size(708, 586);
            panel4.TabIndex = 3;
            panel4.Paint += panel4_Paint;
            // 
            // TblDisplayArticle
            // 
            TblDisplayArticle.ColumnCount = 5;
            TblDisplayArticle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            TblDisplayArticle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            TblDisplayArticle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            TblDisplayArticle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            TblDisplayArticle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            TblDisplayArticle.Dock = DockStyle.Fill;
            TblDisplayArticle.Location = new Point(38, 29);
            TblDisplayArticle.Margin = new Padding(2);
            TblDisplayArticle.Name = "TblDisplayArticle";
            TblDisplayArticle.RowCount = 5;
            TblDisplayArticle.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            TblDisplayArticle.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            TblDisplayArticle.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            TblDisplayArticle.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            TblDisplayArticle.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            TblDisplayArticle.Size = new Size(634, 532);
            TblDisplayArticle.TabIndex = 5;
            // 
            // panel12
            // 
            panel12.Dock = DockStyle.Bottom;
            panel12.Location = new Point(38, 561);
            panel12.Margin = new Padding(2);
            panel12.Name = "panel12";
            panel12.Size = new Size(634, 25);
            panel12.TabIndex = 4;
            // 
            // panel11
            // 
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(38, 0);
            panel11.Margin = new Padding(2);
            panel11.Name = "panel11";
            panel11.Size = new Size(634, 29);
            panel11.TabIndex = 3;
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Right;
            panel8.Location = new Point(672, 0);
            panel8.Margin = new Padding(2);
            panel8.Name = "panel8";
            panel8.Size = new Size(36, 586);
            panel8.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(38, 586);
            panel7.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(34, 87, 122);
            panel9.Controls.Add(tableLayoutPanel4);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(826, 312);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(0, 0, 10, 0);
            panel9.Size = new Size(386, 156);
            panel9.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33332F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel4.Controls.Add(BtnNum0, 1, 3);
            tableLayoutPanel4.Controls.Add(BtnNum1, 0, 0);
            tableLayoutPanel4.Controls.Add(BtnNum2, 1, 0);
            tableLayoutPanel4.Controls.Add(BtnNum3, 2, 0);
            tableLayoutPanel4.Controls.Add(BtnNum4, 0, 1);
            tableLayoutPanel4.Controls.Add(BtnNum5, 1, 1);
            tableLayoutPanel4.Controls.Add(BtnNum6, 2, 1);
            tableLayoutPanel4.Controls.Add(BtnNum7, 0, 2);
            tableLayoutPanel4.Controls.Add(BtnNum8, 1, 2);
            tableLayoutPanel4.Controls.Add(BtnNum9, 2, 2);
            tableLayoutPanel4.Location = new Point(21, 8);
            tableLayoutPanel4.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(375, 145);
            tableLayoutPanel4.TabIndex = 0;
            tableLayoutPanel4.Paint += tableLayoutPanel4_Paint;
            // 
            // BtnNum0
            // 
            BtnNum0.Dock = DockStyle.Fill;
            BtnNum0.Location = new Point(128, 113);
            BtnNum0.Margin = new Padding(4, 5, 4, 5);
            BtnNum0.Name = "BtnNum0";
            BtnNum0.Size = new Size(117, 27);
            BtnNum0.TabIndex = 0;
            BtnNum0.Text = "0";
            BtnNum0.UseVisualStyleBackColor = true;
            // 
            // BtnNum1
            // 
            BtnNum1.Dock = DockStyle.Fill;
            BtnNum1.Location = new Point(3, 3);
            BtnNum1.Name = "BtnNum1";
            BtnNum1.Size = new Size(118, 30);
            BtnNum1.TabIndex = 0;
            BtnNum1.Text = "1";
            BtnNum1.UseVisualStyleBackColor = true;
            // 
            // BtnNum2
            // 
            BtnNum2.Dock = DockStyle.Fill;
            BtnNum2.Location = new Point(128, 5);
            BtnNum2.Margin = new Padding(4, 5, 4, 5);
            BtnNum2.Name = "BtnNum2";
            BtnNum2.Size = new Size(117, 26);
            BtnNum2.TabIndex = 1;
            BtnNum2.Text = "2";
            BtnNum2.UseVisualStyleBackColor = true;
            // 
            // BtnNum3
            // 
            BtnNum3.Dock = DockStyle.Fill;
            BtnNum3.Location = new Point(253, 5);
            BtnNum3.Margin = new Padding(4, 5, 4, 5);
            BtnNum3.Name = "BtnNum3";
            BtnNum3.Size = new Size(118, 26);
            BtnNum3.TabIndex = 2;
            BtnNum3.Text = "3";
            BtnNum3.UseVisualStyleBackColor = true;
            // 
            // BtnNum4
            // 
            BtnNum4.Dock = DockStyle.Fill;
            BtnNum4.Location = new Point(4, 41);
            BtnNum4.Margin = new Padding(4, 5, 4, 5);
            BtnNum4.Name = "BtnNum4";
            BtnNum4.Size = new Size(116, 26);
            BtnNum4.TabIndex = 3;
            BtnNum4.Text = "4";
            BtnNum4.UseVisualStyleBackColor = true;
            // 
            // BtnNum5
            // 
            BtnNum5.Dock = DockStyle.Fill;
            BtnNum5.Location = new Point(128, 41);
            BtnNum5.Margin = new Padding(4, 5, 4, 5);
            BtnNum5.Name = "BtnNum5";
            BtnNum5.Size = new Size(117, 26);
            BtnNum5.TabIndex = 4;
            BtnNum5.Text = "5";
            BtnNum5.UseVisualStyleBackColor = true;
            // 
            // BtnNum6
            // 
            BtnNum6.Dock = DockStyle.Fill;
            BtnNum6.Location = new Point(253, 41);
            BtnNum6.Margin = new Padding(4, 5, 4, 5);
            BtnNum6.Name = "BtnNum6";
            BtnNum6.Size = new Size(118, 26);
            BtnNum6.TabIndex = 5;
            BtnNum6.Text = "6";
            BtnNum6.UseVisualStyleBackColor = true;
            // 
            // BtnNum7
            // 
            BtnNum7.Dock = DockStyle.Fill;
            BtnNum7.Location = new Point(4, 77);
            BtnNum7.Margin = new Padding(4, 5, 4, 5);
            BtnNum7.Name = "BtnNum7";
            BtnNum7.Size = new Size(116, 26);
            BtnNum7.TabIndex = 6;
            BtnNum7.Text = "7";
            BtnNum7.UseVisualStyleBackColor = true;
            // 
            // BtnNum8
            // 
            BtnNum8.Dock = DockStyle.Fill;
            BtnNum8.Location = new Point(128, 77);
            BtnNum8.Margin = new Padding(4, 5, 4, 5);
            BtnNum8.Name = "BtnNum8";
            BtnNum8.Size = new Size(117, 26);
            BtnNum8.TabIndex = 7;
            BtnNum8.Text = "8";
            BtnNum8.UseVisualStyleBackColor = true;
            // 
            // BtnNum9
            // 
            BtnNum9.Dock = DockStyle.Fill;
            BtnNum9.Location = new Point(253, 77);
            BtnNum9.Margin = new Padding(4, 5, 4, 5);
            BtnNum9.Name = "BtnNum9";
            BtnNum9.Size = new Size(118, 26);
            BtnNum9.TabIndex = 8;
            BtnNum9.Text = "9";
            BtnNum9.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(34, 87, 122);
            panel10.Controls.Add(BtnSaveOrder);
            panel10.Controls.Add(BtnTakeAway);
            panel10.Controls.Add(BtnOnSite);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(826, 468);
            panel10.Margin = new Padding(0);
            panel10.Name = "panel10";
            panel10.Size = new Size(386, 159);
            panel10.TabIndex = 5;
            // 
            // BtnSaveOrder
            // 
            BtnSaveOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSaveOrder.Location = new Point(258, 66);
            BtnSaveOrder.Name = "BtnSaveOrder";
            BtnSaveOrder.Size = new Size(119, 62);
            BtnSaveOrder.TabIndex = 2;
            BtnSaveOrder.Text = "Save";
            BtnSaveOrder.UseVisualStyleBackColor = true;
            BtnSaveOrder.Click += BtnSaveOrder_Click;
            // 
            // BtnTakeAway
            // 
            BtnTakeAway.BackColor = Color.FromArgb(255, 128, 0);
            BtnTakeAway.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnTakeAway.ImageIndex = 9;
            BtnTakeAway.ImageList = imageList1;
            BtnTakeAway.Location = new Point(130, 44);
            BtnTakeAway.Name = "BtnTakeAway";
            BtnTakeAway.Size = new Size(80, 65);
            BtnTakeAway.TabIndex = 1;
            BtnTakeAway.Text = "Take Away";
            BtnTakeAway.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnTakeAway.UseVisualStyleBackColor = false;
            BtnTakeAway.Click += BtnTakeAway_Click;
            // 
            // BtnOnSite
            // 
            BtnOnSite.BackColor = Color.FromArgb(255, 128, 0);
            BtnOnSite.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnOnSite.ImageIndex = 8;
            BtnOnSite.ImageList = imageList1;
            BtnOnSite.Location = new Point(38, 44);
            BtnOnSite.Name = "BtnOnSite";
            BtnOnSite.Size = new Size(85, 65);
            BtnOnSite.TabIndex = 0;
            BtnOnSite.Text = "On Site";
            BtnOnSite.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnOnSite.UseVisualStyleBackColor = false;
            BtnOnSite.Click += BtnOnSite_Click;
            // 
            // CardUserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 222, 156);
            Controls.Add(tableLayoutPanel1);
            Name = "CardUserControl1";
            Size = new Size(1212, 627);
            Load += CardUserControl1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel9.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel10.ResumeLayout(false);
            ResumeLayout(false);
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
        private ImageList imageList1;
    }
}
