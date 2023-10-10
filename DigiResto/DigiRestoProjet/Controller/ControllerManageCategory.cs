using DigiRestoProjet.Model;

namespace DigiRestoProjet.Controller
{
    internal class ControllerManageCategory
    {

        public ControllerManageCategory() {
        
        }

        public static void InitializeCatCombobox(ComboBox comboBoxCategory)
        {
            comboBoxCategory.Items.Clear();
            if (GlobalVariable.categoryList.Count > 0)
            {
                foreach(Category cat in GlobalVariable.categoryList)
                {
                    comboBoxCategory.Items.Add(cat);
                    comboBoxCategory.ValueMember = "Name";
                   

                }
                comboBoxCategory.SelectedIndex = 0;
            }
        }
    }
}
