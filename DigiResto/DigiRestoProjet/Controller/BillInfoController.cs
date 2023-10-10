using DigiRestoProjet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DigiRestoProjet.Controller
{
    public class BillInfoController
    {
        private static BillInfoController? instance;
        public static BillInfoController Instance 
        {
            get { if (instance == null) instance = new BillInfoController() ; return instance; } 
            private set { instance = value; }
        }

        public List<BillInfo> GetBillInfo()
        {
            string fileName = "..\\..\\..\\Json\\BillInfo.json";
            string jsonString = File.ReadAllText(fileName);
            List<BillInfo> list = JsonSerializer.Deserialize<List<BillInfo>>(jsonString)!;
            return list;
        }

        public bool AddNewBillInfo(int billId, List<FoodQuantity> listFood)
        {
            string fileName = "..\\..\\..\\Json\\BillInfo.json";
            string jsonString = File.ReadAllText(fileName);
            List<BillInfo> list = JsonSerializer.Deserialize<List<BillInfo>>(jsonString)!;
            

            BillInfo newBillInfo = new BillInfo();
            newBillInfo.Id = list.Count + 1;
            newBillInfo.BillId = billId;
            newBillInfo.Food = listFood;

            list.Add(newBillInfo);

            string newJson = JsonSerializer.Serialize(list);
            File.WriteAllText(fileName, newJson);

            return true;
        }
        
        public bool UpdateBillInfo(int BillId, List<FoodQuantity> listFood)
        {
            string fileName = "..\\..\\..\\Json\\BillInfo.json";
            string jsonString = File.ReadAllText(fileName);
            List<BillInfo> list = JsonSerializer.Deserialize<List<BillInfo>>(jsonString)!;

            BillInfo billInfo = list.Where(p => p.BillId == BillId).FirstOrDefault();
            if(billInfo != null) billInfo.Food = listFood;

            string newJson = JsonSerializer.Serialize(list);
            File.WriteAllText(fileName, newJson);

            return true;
        }

        public List<BillInfo> GetListBillInfoByID(List<Bill> billList)
        {
            string fileName = "..\\..\\..\\Json\\BillInfo.json";
            string jsonString = File.ReadAllText(fileName);
            List<BillInfo> BillInfoList = JsonSerializer.Deserialize<List<BillInfo>>(jsonString)!;

            List<BillInfo> newList = new List<BillInfo>();

            foreach(Bill bill in billList)
            {
                foreach(BillInfo billInfo in BillInfoList)
                {
                    if(billInfo.BillId == bill.Id)
                    {
                        newList.Add(billInfo);
                    }
                }
            }

            return newList;
        }
        public bool AddArticleMenuInBill(int billId, List<ArticleMenu> menus)
        {
            string fileName = "..\\..\\..\\Json\\BillInfo.json";
            string jsonString = File.ReadAllText(fileName);
            List<BillInfo> list = JsonSerializer.Deserialize<List<BillInfo>>(jsonString)!;

            BillInfo billInfo = list.Where(p => p.BillId == billId).FirstOrDefault();
            if (billInfo != null) billInfo.Menu = menus;

            string newJson = JsonSerializer.Serialize(list);
            File.WriteAllText(fileName, newJson);
            return true;
        }
    }
}
