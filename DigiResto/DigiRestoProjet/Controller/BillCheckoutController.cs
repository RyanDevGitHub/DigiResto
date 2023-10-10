using DigiRestoProjet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DigiRestoProjet.Controller
{
    public class BillCheckoutController
    {
        private static BillCheckoutController? instance;

        public static BillCheckoutController Instance
        {
            get { if (instance == null) instance = new BillCheckoutController(); return instance; }
            private set { instance = value; }
        }
        public bool LoadBill()
        {
            string fileName = "..\\..\\..\\Json\\BillUpdateCheckout.json";
            string jsonString = File.ReadAllText(fileName);
            Bill data = JsonSerializer.Deserialize<Bill>(jsonString)!;

            if (data == null)
            {
                return false;
            }
            else
            {
                return true;
            } 
        }
        
        public int GetIdBill()
        {
            string fileName = "..\\..\\..\\Json\\BillUpdateCheckout.json";
            string jsonString = File.ReadAllText(fileName);
            Bill data = JsonSerializer.Deserialize<Bill>(jsonString)!;
           
            if(data.Id  != 0)
            {
                int id = data.Id;
                return id;
            }
            return -1;            
        }
        public int GetTableBill()
        {
            string fileName = "..\\..\\..\\Json\\BillUpdateCheckout.json";
            string jsonString = File.ReadAllText(fileName);
            Bill data = JsonSerializer.Deserialize<Bill>(jsonString)!;

            if(data != null)
            {
                return data.TableId;
            }
            return -1;
        }
        public void SetBill(int billId, int tableId)
        {
            string fileName = "..\\..\\..\\Json\\BillUpdateCheckout.json";
            string jsonString = File.ReadAllText(fileName);
            Bill billData = JsonSerializer.Deserialize<Bill>(jsonString)!;

            Bill newBill = new Bill();
            newBill.Id = billId;
            newBill.TableId = tableId;
            

            string newJson = JsonSerializer.Serialize(newBill);
            File.WriteAllText(fileName, newJson);

        }
        public void ResetBill()
        {
            string fileName = "..\\..\\..\\Json\\BillUpdateCheckout.json";
            string jsonString = File.ReadAllText(fileName);
            Bill billData = JsonSerializer.Deserialize<Bill>(jsonString)!;

            billData.Id = 0;


            string newJson = JsonSerializer.Serialize(billData);
            File.WriteAllText(fileName, newJson);
        }
    }
}
