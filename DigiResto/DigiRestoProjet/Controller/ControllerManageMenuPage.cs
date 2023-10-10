using DigiRestoProjet.Model;
using DigiRestoProjet.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiRestoProjet.Controller
{
    public class ControllerManageMenuPage
    {
     
        public static void UpdateMenuInComboBox(ManageMenu manageMenuPage, ComboBox manageMenuComboBox) //for Update and Init
        {
            // comboBoxCategory.Items.AddRange();
            if (GlobalVariable.articleList.Count > 0)
            {
                manageMenuComboBox.Items.Clear();
                foreach (Menu a in GlobalVariable.menuList)
                {
                    manageMenuComboBox.Items.Add(a);
                    manageMenuComboBox.ValueMember = "Name";
                }

                manageMenuComboBox.SelectedIndex = 0;
            }
        }
        public static void UpdateMenu(ManageMenu manageMenu)
        {


            manageMenu.Close(); 

        }
    }


}
