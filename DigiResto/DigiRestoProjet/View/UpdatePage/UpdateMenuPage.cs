using DigiRestoProjet.Controller;
using DigiRestoProjet.Model;
using DigiRestoProjet.Model.custom_control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiRestoProjet.View
{
    public partial class UpdateMenuPage : Form
    {
        private ManageMenu _manageMenu;
        public ManageMenu ManageMenu
        {
            get {return _manageMenu; }
            set { _manageMenu = value; }
        }
        private ComboBox _comboboxManageMenu;
        public ComboBox ComboboxManageMenu
        {
            get { return _comboboxManageMenu; }
            set { _comboboxManageMenu = value; }
        }
        private Menu _menuSelected;
        public Menu MenuSelected
        {
            get { return _menuSelected; }
            set { _menuSelected = value; }
        }
        public UpdateMenuPage(string oldname, string olddescription,string oldprice,Menu menu)
        {
            InitializeComponent();
            this.NewNameMenuTextBox.Text = oldname;
            this.NewDescMenuTextBox.Text = olddescription;  
            this.NewPriceMenuTextBox.Text = oldprice;
            ControllerUpdateMenuPage.InitCheckComboBox(menu, NewcheckedComboBoxEnter, NewcheckedComboBoxDish, NewcheckedComboBoxDessert);
        }

        private void UpdateMenu_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var listChecked = MenuArticle_checkedListBox1.CheckedItems;
            //if (listChecked.Count != 0)
            //{
            /*    if (textBox2.Text != null)
                {
                    GlobalVariable.articleList[indexCatSelected].Name = textBox2.Text;
   
                }
            */
            //}
            MessageBox.Show("Your category was Updated ");
            this.Close();
        }

        private void BtnUpdateMenu_Click(object sender, EventArgs e)
        {
            var indexSelected = GlobalVariable.menuList.IndexOf(MenuSelected);
            foreach (Category category in GlobalVariable.categoryList)
            {
                if (category.MenuList != null)
                {
                    foreach (Menu menu in category.MenuList)
                    {
                        if (menu.Name == MenuSelected.Name)
                        {
                            menu.DessertArticle.Clear();
                            menu.EnterArticle.Clear();
                            menu.DessertArticle.Clear();
                            menu.Name = this.NewNameMenuTextBox.Text;
                            menu.Price = Convert.ToInt32(this.NewPriceMenuTextBox.Text);
                            foreach (Article a in this.NewcheckedComboBoxDish.CheckedItems)
                            {
                                MenuSelected.DishArticle.Add((Article)a);
                            }
                            foreach (Article a in this.NewcheckedComboBoxDessert.CheckedItems)
                            {
                                MenuSelected.DessertArticle.Add((Article)a);
                            }
                            foreach (Article a in this.NewcheckedComboBoxEnter.CheckedItems)
                            {
                                MenuSelected.EnterArticle.Add((Article)a);
                            }
                        }
                    }
                }
            }
            GlobalVariable.menuList[indexSelected].DishArticle.Clear();
            GlobalVariable.menuList[indexSelected].EnterArticle.Clear();
            GlobalVariable.menuList[indexSelected].DessertArticle.Clear();

            GlobalVariable.menuList[indexSelected].Name = this.NewNameMenuTextBox.Text;
            GlobalVariable.menuList[indexSelected].Description = this.NewDescMenuTextBox.Text;
            GlobalVariable.menuList[indexSelected].Price = Convert.ToInt32(this.NewPriceMenuTextBox.Text);
            foreach (Article a in this.NewcheckedComboBoxDish.CheckedItems)
            {
                GlobalVariable.menuList[indexSelected].DishArticle.Add((Article)a);
            }
            foreach (Article a in this.NewcheckedComboBoxDessert.CheckedItems)
            {
                GlobalVariable.menuList[indexSelected].DessertArticle.Add((Article)a);
            }
            foreach (Article a in this.NewcheckedComboBoxEnter.CheckedItems)
            {
                GlobalVariable.menuList[indexSelected].EnterArticle.Add((Article)a);
            }
            MessageBox.Show("Your menu was Update ");
            this.Close();
            ControllerManageMenuPage.UpdateMenuInComboBox(ManageMenu, ComboboxManageMenu);
        }
    }
}
