using DigiRestoProjet.Model;
using DigiRestoProjet.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiRestoProjet.Controller
{
    internal class ControllerManageTable
    {

        public static void UpdateInitManageTableComboBox(ComboBox manageTableCombobox)
        {
  
            manageTableCombobox.Items.Clear();
            string prefix = "Table n°";
            foreach(Table table in GlobalVariable.tableList)
            {
                manageTableCombobox.Items.Add(table);
                manageTableCombobox.DisplayMember = "Name";
                manageTableCombobox.ValueMember = "Id";
                
            }
            if(GlobalVariable.tableList.Count >0 )
            {
                manageTableCombobox.SelectedIndex = 0;
            }
            
        }
    }
}
