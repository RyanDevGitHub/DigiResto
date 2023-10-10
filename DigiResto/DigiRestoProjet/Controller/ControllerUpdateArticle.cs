using DigiRestoProjet.Model;
using DigiRestoProjet.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiRestoProjet.Controller
{
    internal class ControllerUpdateArticle
    {
        public static void InitCheckBox(UpdateArticlePage instance)
        {
            
            instance.dataGridViewUpdateArticle.DataSource = GlobalVariable.ingredientList;
            for (int i = 0; i < instance.dataGridViewUpdateArticle.Columns.Count; i++)
            {
                instance.dataGridViewUpdateArticle.Columns[i].Visible = false;
            }
            instance.dataGridViewUpdateArticle.Columns["Name"].Visible = true;
            instance.dataGridViewUpdateArticle.Columns["Name"].DisplayIndex = 0;
            instance.dataGridViewUpdateArticle.Columns["Name"].ReadOnly = true;
            instance.dataGridViewUpdateArticle.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            instance.dataGridViewUpdateArticle.Columns["CheckBoxColumn"].Visible = true;
            instance.dataGridViewUpdateArticle.Columns["CheckBoxColumn"].DisplayIndex = 1;
            instance.dataGridViewUpdateArticle.Columns["QuantityColumn"].Visible = true;
            instance.dataGridViewUpdateArticle.Columns["QuantityColumn"].DisplayIndex = 2;
            instance.dataGridViewUpdateArticle.Columns["UnitColumn"].Visible = true;
            instance.dataGridViewUpdateArticle.Columns["UnitColumn"].DisplayIndex = 3;

            foreach (Ingredient ingredient in GlobalVariable.articleList[instance.IndexArticleSelected]._ingredientList)
            {

                foreach (DataGridViewRow  row in instance.dataGridViewUpdateArticle.Rows)
                {
                    if(ingredient.Name == (string)row.Cells["Name"].Value) {

                        row.Cells["CheckBoxColumn"].Value = true;
                        row.Cells["QuantityColumn"].Value = "test";//ingredient.Quantity;
                        row.Cells["UnitColumn"].Value = 0;

                    }
                }
            }
        }
        public static void UpdateArticle( UpdateArticlePage updateArticlePage)
        {
            string name = updateArticlePage.NameArticleUpdateTextBox.Text;
            string description = updateArticlePage.DescArticleUpdateTextBox.Text;
            double price = Convert.ToDouble(updateArticlePage.PriceArticleUpdateTextBox.Text);
            List<Ingredient> checkedList = new();
            foreach (DataGridViewRow row in updateArticlePage.dataGridViewUpdateArticle.Rows) //check checkbox cell if is true créate new ingredient for the update article
            {

                var checkbox = row.Cells["CheckBoxColumn"].Value;
                if (checkbox != null)
                {
                    if ((bool)checkbox == true)
                    {
                        var namerow = row.Cells["Name"].Value;
                        var quantity = row.Cells["QuantityColumn"].Value;
                        var unit = row.Cells["UnitColumn"].Value;
                        Enum.TryParse((string)unit, out Units unitValue);
                        var newingredient = new Ingredient((string)namerow, Convert.ToInt32(quantity), unitValue);
                        checkedList.Add(newingredient);
                    }
                }
            }
            GlobalVariable.articleList[updateArticlePage.IndexArticleSelected].Name = name;
            GlobalVariable.articleList[updateArticlePage.IndexArticleSelected].Description = description;
            GlobalVariable.articleList[updateArticlePage.IndexArticleSelected].Price = price;
            GlobalVariable.articleList[updateArticlePage.IndexArticleSelected]._ingredientList.Clear();
            foreach(Ingredient ingredient in checkedList)
            {
                GlobalVariable.articleList[updateArticlePage.IndexArticleSelected]._ingredientList.Add(ingredient);
            }
            if (GlobalVariable.categoryList.Count > 0)
            {
                ControllerCardUserControl.DisplayArticleMenu(GlobalVariable.categoryList[0], CardUserControl1.Instance.TblDisplayArticle, CardUserControl1.Instance);
            }
            MessageBox.Show("Your article was Update ");
            updateArticlePage.Close();
        }
    }
}
