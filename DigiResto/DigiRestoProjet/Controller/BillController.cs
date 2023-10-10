using DigiResto.Controller;
using DigiRestoProjet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DigiRestoProjet.Controller
{
    public class BillController
    {
        private static BillController? instance;
        
        public static BillController Instance 
        {
            get { if (instance == null) instance = new BillController(); return instance; } 
            private set { instance = value; }
        }
        public List<Bill> LoadBill()
        {
            string fileName = "..\\..\\..\\Json\\Bill.json";
            string jsonString = File.ReadAllText(fileName);
            List<Bill> list = JsonSerializer.Deserialize<List<Bill>>(jsonString)!;

            return list;
        }
        
        public List<Bill> LoadCheckOutBill()
        {
            List<Bill> list = LoadBill();
            list = list.Where(p => p.IsCheckOut == true).ToList();
            return list;
        }
        public Bill GetNotCheckOutBillById(int id)
        {
            List<Bill> list = LoadBill();
            Bill bill = list.Where(p => p.IsCheckOut == false && p.Id == id).FirstOrDefault();

            return bill;
        }
        public Bill LoadCheckOutBillById(int id)
        {
            List<Bill> list = LoadBill();
            Bill bill = list.Where(p => p.IsCheckOut == true && p.Id == id).FirstOrDefault();
            
            return bill;
        }

        public List<Bill> LoadCheckOutBillByDate(DateTime dateCheckOut)
        {
            List<Bill> newList = new List<Bill>();
            List<Bill> list = LoadBill();

            int day = dateCheckOut.Day;
            int month = dateCheckOut.Month;
            int year = dateCheckOut.Year;
            //list = list.Where(p => p.IsCheckOut == true && p.DateCheckIn == dateCheckIn).ToList();
            foreach(Bill bill in list)
            {
                if(bill.IsCheckOut == true/* && bill.DateCheckOut.Day == day && bill.DateCheckOut.Month == month && bill.DateCheckOut.Year == year*/)
                {
                    if(bill.DateCheckOut.Day == day && bill.DateCheckOut.Month == month && bill.DateCheckOut.Year == year)
                    {
                        newList.Add(bill);
                    }
                }
            }
            return newList;
        }

        public int GetBillId()
        {
            
            List<Bill> list = LoadBill();

            int lastIndex = list.Count - 1;
            int billID = list[lastIndex].Id;
            return billID;           
        }

        public bool AddNewBillOnSite(int TableId)
        {
            string fileName = "..\\..\\..\\Json\\Bill.json";
            string jsonString = File.ReadAllText(fileName);
            List<Bill> list = JsonSerializer.Deserialize<List<Bill>>(jsonString)!;

            Bill newBill = new Bill();
            newBill.Id = list.Count + 1;
            newBill.TableId = TableId;
            newBill.DateCheckIn = DateTime.Now;
            newBill.IsCheckOut = false;
            newBill.Manage = UserController.Instance.GetManageName();
            list.Add(newBill);

            string newJson = JsonSerializer.Serialize(list);
            File.WriteAllText(fileName, newJson);

            return true;
        }
        public bool AddNewBillTakeAway(float total)
        {
            string fileName = "..\\..\\..\\Json\\Bill.json";
            string jsonString = File.ReadAllText(fileName);
            List<Bill> list = JsonSerializer.Deserialize<List<Bill>>(jsonString)!;

            Bill newBill = new Bill();
            newBill.Id = list.Count + 1;
            newBill.TableId = 0;
            newBill.DateCheckIn = DateTime.Now;
            newBill.IsCheckOut = false;
            newBill.Total = total;
            newBill.Manage = UserController.Instance.GetManageName();
            list.Add(newBill);

            string newJson = JsonSerializer.Serialize(list);
            File.WriteAllText(fileName, newJson);

            return true;
        }

        public bool AddTotalPrice(float total)
        {
            string fileName = "..\\..\\..\\Json\\Bill.json";
            string jsonString = File.ReadAllText(fileName);
            List<Bill> list = JsonSerializer.Deserialize<List<Bill>>(jsonString)!;
            
            int lastIndex = list.Count - 1;
            int billID = list[lastIndex].Id;
            foreach(Bill bill in list)
            {
                if(bill.Id == billID)
                {
                    bill.Total = total;
                }
            }
            string newJson = JsonSerializer.Serialize(list);
            File.WriteAllText(fileName, newJson);
            return true;
        }

        public bool UpdateTotalPrice(float total, int billId)
        {
            string fileName = "..\\..\\..\\Json\\Bill.json";
            string jsonString = File.ReadAllText(fileName);
            List<Bill> list = JsonSerializer.Deserialize<List<Bill>>(jsonString)!;

            Bill bill = list.Where(p => p.Id == billId).FirstOrDefault();
            if(bill != null)
            {
                bill.Total = total;
            }
            string newJson = JsonSerializer.Serialize(list);
            File.WriteAllText(fileName, newJson);
            return true;
        }
        public bool SetBillCheckOut(int billId, string paymentMethod)
        {
            string fileName = "..\\..\\..\\Json\\Bill.json";
            string jsonString = File.ReadAllText(fileName);
            List<Bill> list = JsonSerializer.Deserialize<List<Bill>>(jsonString)!;
            Bill bill = list.Where(p => p.Id == billId).FirstOrDefault();
            if(bill != null)
            {
                bill.IsCheckOut = true;
                bill.DateCheckOut = DateTime.Now;
                bill.PaymentMethod = paymentMethod;
            }
            string newJson = JsonSerializer.Serialize(list);
            File.WriteAllText(fileName, newJson);
            return true;
        }

        public List<Bill> LoadBillByMonth(int month)
        {
            List<Bill> newList = new List<Bill>();
            List<Bill> list = LoadBill();

    
            //list = list.Where(p => p.IsCheckOut == true && p.DateCheckIn == dateCheckIn).ToList();
            foreach (Bill bill in list)
            {
                if (bill.IsCheckOut == true/* && bill.DateCheckOut.Day == day && bill.DateCheckOut.Month == month && bill.DateCheckOut.Year == year*/)
                {
                    if (bill.DateCheckOut.Month == month)
                    {
                        newList.Add(bill);
                    }
                }
            }
            return newList;
        }
    }
}
