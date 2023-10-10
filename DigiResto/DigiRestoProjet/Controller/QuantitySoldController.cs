using DigiRestoProjet.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiRestoProjet.Controller
{
    public class QuantitySoldController
    {
        private static QuantitySoldController instance;
        public static QuantitySoldController Instance
        {
            get { if (instance == null) instance = new QuantitySoldController();  return instance; }
            set { instance = value; }
        }

        public List<QuantitySold> loadQuantitySold()
        {
            var path = Directory.GetParent(System.Environment.CurrentDirectory).Parent.Parent.FullName;
            string fileName = path + "\\Json\\QuantitySold.json";
            if (File.Exists(fileName))
            {
                List<QuantitySold> List = JsonConvert.DeserializeObject<List<QuantitySold>>(File.ReadAllText(fileName));
                return List;
            }
            return null;
        }

        public IDictionary<string, int> UpdateQuantitySoldByMonth(int month)
        {

            List<Bill> billList = BillController.Instance.LoadBillByMonth(month);
            List<BillInfo> billInfoList = BillInfoController.Instance.GetListBillInfoByID(billList);

            IDictionary<string, int> foodCount = new Dictionary<string, int>();

            foreach (BillInfo billInfo in billInfoList)
            {
                foreach(var food in billInfo.Food)
                { 
                    if (foodCount.ContainsKey(food.FoodName))
                    {
                        foodCount[food.FoodName] += food.Quantity;
                    }
                    else
                    {
                        foodCount.Add(food.FoodName,food.Quantity);
                    }
                }
            }

            return foodCount;
        }
    }
}
