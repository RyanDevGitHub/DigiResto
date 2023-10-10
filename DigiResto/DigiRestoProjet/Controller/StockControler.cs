using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using DigiResto;
using DigiResto.Controller;
using DigiRestoProjet.Model;
using Projet_Pi_DIGIRESTO.View;

namespace DigiRestoProjet.Controller
{
    internal static class StockControler
    {


        public static bool CheckStockCanAdd(ObservableCollection<Stock> stocklist, string name, DateTime dateOfPeremption)
        {
            foreach (Stock stock in GlobalVariable.stockList)
            {
                if (stock.DateOfPeremption == dateOfPeremption && stock.Name == name)
                {
                    return false;
                }

            }
            return true;
        }
        
       

        public static bool ChangeStockQuantity(string stockName, int quantity)
        {
            foreach (Stock stock in GlobalVariable.stockList)
            {
                if(stock.Name == stockName)
                {
                    stock.Quantity = stock.Quantity - quantity;
                }
            }

            return true;
        }
        public static bool UpdateStockQuantity(int BillId)
        {
            string fileName = "..\\..\\..\\Json\\Stock.json";
            string jsonString = File.ReadAllText(fileName);

            List<BillInfo> billInfoList = BillInfoController.Instance.GetBillInfo();
           
            BillInfo billInfo = billInfoList.Where(p => p.BillId == BillId).FirstOrDefault();
            List<FoodQuantity> FoodList = billInfo.Food;

            ObservableCollection<Stock> stocks = GlobalVariable.stockList;

            int TotalIngredient;
            List<Ingredient> Ingredientlist = new List<Ingredient>();
            List<Article> ArticleList = ArticleController.Instance.LoadArticle();
            List<ArticleMenu> MenuList = ArticleMenuController.Instance.LoadArticleMenu();

            foreach (FoodQuantity food in FoodList)
            {
                string ArticleName = food.FoodName;
                foreach(Article article in ArticleList)
                {
                    if(article.Name == ArticleName)
                    {
                        Ingredientlist = ArticleController.Instance.GetIngredientList(food.FoodName);
                        foreach (Ingredient ingredient in Ingredientlist)
                        {
                            bool calculated = false;
                            MessageBox.Show((ingredient.Quantity * food.Quantity).ToString());
                            //TotalIngredient = ingredient.Quantity * food.Quantity;
                            foreach (Stock stock in stocks)
                            {
                                if (stock.Name == ingredient.Name && !calculated)
                                {
                                    stock.Quantity = stock.Quantity - (ingredient.Quantity * food.Quantity);
                                    //TotalIngredient = 0;
                                    calculated = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach(ArticleMenu articleMenu in MenuList)
                        {
                            if (article.Name.Equals(articleMenu.FoodName))
                            {
                                Ingredientlist = ArticleController.Instance.GetIngredientList(article.Name);
                                foreach (Ingredient ingredient in Ingredientlist)
                                {
                                    bool calculated = false;
                                   // MessageBox.Show((ingredient.Quantity * food.Quantity).ToString());
                                    //TotalIngredient = ingredient.Quantity * food.Quantity;
                                    foreach (Stock stock in stocks)
                                    {
                                        if (stock.Name == ingredient.Name && !calculated)
                                        {
                                            stock.Quantity = stock.Quantity - (ingredient.Quantity * food.Quantity);
                                            //TotalIngredient = 0;
                                            calculated = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                string newJson = JsonSerializer.Serialize(stocks);
                File.WriteAllText(fileName, newJson);
            }
            return true;
        }
    }
}
