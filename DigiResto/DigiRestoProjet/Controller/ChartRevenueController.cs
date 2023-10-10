using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DigiRestoProjet.Model;

namespace DigiRestoProjet.Controller
{
    public class ChartRevenueController
    {
        private static ChartRevenueController instance;
        public static ChartRevenueController Instance 
        { get { if (instance == null) instance = new ChartRevenueController(); return instance; } 
          set { instance = value; }
        }

        public List<Revenue> CalculeRevenue()
        {
            float jan = 0;
            float feb = 0;
            float mar = 0;
            float apr = 0;
            float may = 0;
            float jun = 0;
            float jul = 0;
            float aug = 0;
            float sep = 0;
            float oct = 0;
            float nov = 0;
            float dec = 0;
            float sum = 0;
            List<Bill> billList = BillController.Instance.LoadBill();
            foreach (Bill bill in billList)
            {
                if (bill.DateCheckOut.Month == 1)
                {
                    jan += bill.Total;
                }
                else if (bill.DateCheckOut.Month == 2)
                {
                    feb += bill.Total;
                }
                else if (bill.DateCheckOut.Month == 3)
                {
                    mar += bill.Total;
                }
                else if (bill.DateCheckOut.Month == 4)
                {
                    apr += bill.Total;
                }
                else if (bill.DateCheckOut.Month == 5)
                {
                    may += bill.Total;
                }
                else if (bill.DateCheckOut.Month == 6)
                {
                    jun += bill.Total;
                }
                else if (bill.DateCheckOut.Month == 7)
                {
                    jul += bill.Total;
                }
                else if (bill.DateCheckOut.Month == 8)
                {
                    aug += bill.Total;
                }
                else if (bill.DateCheckOut.Month == 9)
                {
                    sep += bill.Total;
                }
                else if (bill.DateCheckOut.Month == 10)
                {
                    oct += bill.Total;
                }
                else if (bill.DateCheckOut.Month == 11)
                {
                    nov += bill.Total;
                }
                else if (bill.DateCheckOut.Month == 12)
                {
                    dec += bill.Total;
                }
                sum +=bill.Total;
            }
            //string fileName = "..\\..\\..\\Json\\Revenue.json";
            //string jsonString = File.ReadAllText(fileName);
            //List<Revenue> list = JsonSerializer.Deserialize<List<Revenue>>(jsonString)!;

            string fileName = "..\\..\\..\\Json\\Revenue.json";
            string jsonString = File.ReadAllText(fileName);
            List<Revenue> list = JsonSerializer.Deserialize<List<Revenue>>(jsonString)!;

            foreach (Revenue revenue in list)
            {
                if(revenue.year == 2023)
                {
                    revenue.sum = sum;
                    foreach (RevenueByMonth item in revenue.total)
                    {
                        if (item.month == "jan")
                        {
                            item.revenue = jan;
                        }
                        if (item.month == "feb")
                        {
                            item.revenue = feb;
                        }
                        if (item.month == "mar")
                        {
                            item.revenue = mar;
                        }
                        if (item.month == "apr")
                        {
                            item.revenue = apr;
                        }
                        if (item.month == "may")
                        {
                            item.revenue = may;
                        }
                        if (item.month == "jun")
                        {
                            item.revenue = jun;
                        }
                        if (item.month == "jul")
                        {
                            item.revenue = jul;
                        }
                        if (item.month == "aug")
                        {
                            item.revenue = aug;
                        }
                        if (item.month == "sep")
                        {
                            item.revenue = sep;
                        }
                        if (item.month == "oct")
                        {
                            item.revenue = oct;
                        }
                        if (item.month == "nov")
                        {
                            item.revenue = nov;
                        }
                        if (item.month == "dec")
                        {
                            item.revenue = dec;
                        }
                    }
                }
                
            }
            string newJson = JsonSerializer.Serialize(list);
            File.WriteAllText(fileName, newJson);
            return list;
        }

        public double getCAbyDate(DateTime date)
        {
            double result = 0;
            List<Bill> billList = BillController.Instance.LoadBill();
            foreach (Bill bill in billList)
            {
                if(bill.DateCheckOut.Date.Equals(date))
                {
                    result += bill.Total;
                    return result;
                }
            }
            return result;
        }
    }
}
