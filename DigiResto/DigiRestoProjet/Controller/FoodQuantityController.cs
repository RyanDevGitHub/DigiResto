using DigiRestoProjet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DigiRestoProjet.Controller
{
    public class FoodQuantityController
    {
        private static FoodQuantityController? instance;

        public static FoodQuantityController Instance
        {
            get { if (instance == null) instance = new FoodQuantityController() ; return instance; }
            set { instance = value; }
        }

        public List<FoodQuantity> AddNewFoodQuantity(List<FoodQuantity> newList)
        {
            string fileName = "..\\..\\..\\Json\\FoodQuantity.json";
            string jsonString = File.ReadAllText(fileName);
            List<FoodQuantity> list = JsonSerializer.Deserialize<List<FoodQuantity>>(jsonString)!;

            list = newList;

            string newJson = JsonSerializer.Serialize(list);
            File.WriteAllText(fileName, newJson);

            return list;
        }
        
    }
}
