using DigiRestoProjet.Controller;
using DigiRestoProjet.Model;
using DigiRestoProjet.Model.custom_control;
using DigiRestoProjet.View.AddPage;
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
    public partial class ManageMenu : Form
    {
        private Menu _menuSelected;
        public Menu MenuSelected
        {
            get { return _menuSelected; }
            set { _menuSelected = value; }
        }
        private int _indeMenuSelected;
        public int IndexMenuSelected
        {
            get { return _indeMenuSelected; }
            set { _indeMenuSelected = value; }
        }

        public ManageMenu()
        {
            InitializeComponent();
            foreach (Menu menu in GlobalVariable.menuList)
            {
                cbListMenu.Items.Add(menu);
                cbListMenu.DisplayMember = "Name";
                cbListMenu.SelectedIndex = 0;
            }
            GlobalVariable.menuList.CollectionChanged += MenuList_CollectionChanged1;

        }

        private void MenuList_CollectionChanged1(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    ControllerManageMenuPage.UpdateMenuInComboBox(this,cbListMenu);
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    ControllerManageMenuPage.UpdateMenuInComboBox(this, cbListMenu);
                    break;
            }
        }
        private void BtnAddMenu_Click(object sender, EventArgs e)
        {
            AddMenuPage addMenuPage = new();
            addMenuPage.ShowDialog();
        }

        private void cbListMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var menuSelected = (Menu)cbListMenu.SelectedItem;
            var indexofmenuSelected = GlobalVariable.menuList.IndexOf(menuSelected);
            List<int> listMenuIndiceDelete = new List<int>();
            int cptcategory = 0;
            int cptarticle = 0;
            foreach (Category category in GlobalVariable.categoryList)
            {
                if(category.MenuList != null)
                {
                    foreach (Menu menu in category.MenuList)
                    {
                        if (menu == menuSelected)
                        {
                            listMenuIndiceDelete.Add(cptcategory);
                        }
                        cptarticle++;
                    }
                    cptcategory++;
                }
            }
            foreach (int i in listMenuIndiceDelete)
            {
                GlobalVariable.categoryList[i].MenuList.Remove(menuSelected);

            }

            foreach (Category cat in GlobalVariable.categoryList)
            {
                if (cat.MenuList != null)
                {
                    cat.MenuList.Remove(menuSelected);
                }
            }
            MessageBox.Show("You artcile '" + menuSelected.Name + "' was deleted") ;
            GlobalVariable.menuList.Remove(menuSelected);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var menuSelected = (Menu)cbListMenu.SelectedItem;
            UpdateMenuPage updateMenuPage = new(menuSelected.Name, menuSelected.Description, Convert.ToString(menuSelected.Price), menuSelected);           
            updateMenuPage.ManageMenu = this;
            updateMenuPage.ComboboxManageMenu = cbListMenu;
            updateMenuPage.MenuSelected= menuSelected;
            updateMenuPage.ShowDialog();
        }
    }
}
