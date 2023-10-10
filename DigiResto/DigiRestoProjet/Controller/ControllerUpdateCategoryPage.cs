using CheckComboBoxTest;
using DigiRestoProjet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiRestoProjet.Controller
{
    public class ControllerUpdateCategoryPage
    {
        public static void InitComboboxMenu(CheckedListBox ccb,Category catselected)
        {
            ccb.Items.Clear();
            foreach (Menu menus in GlobalVariable.menuList)
            {
                bool menuSet = false;
                foreach (Menu menu in catselected.MenuList)
                {
                    if(menu.Name == menus.Name)
                    {
                        ccb.Items.Add(menus,true);
                        ccb.DisplayMember = "Name";
                        menuSet = true;
                    }
                }
                if (menuSet == false) {
                    ccb.Items.Add(menus, false);
                    ccb.DisplayMember = "Name";
                }
            }
        }
    }
}
