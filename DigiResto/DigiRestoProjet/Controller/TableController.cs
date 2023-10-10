using DigiRestoProjet.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DigiRestoProjet.Controller
{
    public class TableController
    {
        private static TableController? instance;

        public static TableController Instance
        {
            get { if (instance == null) instance = new TableController(); { return instance; } }
            private set { instance = value; }
        }

        public static int TableWidth = 90;
        public static int TableHeight = 90;

        public List<Table> GetTableAvailable()
        {
            //string fileName = "..\\..\\..\\Json\\Table.json";
            //string jsonString = File.ReadAllText(fileName);
            //List<Table> list = JsonSerializer.Deserialize<List<Table>>(jsonString)!;

            List<Table> newList = GlobalVariable.tableList.Where(o => o.IsAvailable == true).ToList();
            return newList;
        }
        public bool SetTableNotAvailable(int tableId)
        {
            string fileName = "..\\..\\..\\Json\\Table.json";
            string jsonString = File.ReadAllText(fileName);
            List<Table> list = JsonSerializer.Deserialize<List<Table>>(jsonString)!;

            if(list.Count > 0)
            {
                Table table = list.Where(t => t.Id == tableId).FirstOrDefault();
                if(table != null)
                {
                    table.IsAvailable = false;
                    string newJson = JsonSerializer.Serialize(list);
                    File.WriteAllText(fileName, newJson);
                    return true;
                }
            }
            return false;
        }
        public bool SetTableAvailable(int tableId)
        {
            string fileName = "..\\..\\..\\Json\\Table.json";
            string jsonString = File.ReadAllText(fileName);
            List<Table> list = JsonSerializer.Deserialize<List<Table>>(jsonString)!;

            if (list.Count > 0)
            {
                Table table = list.Where(t => t.Id == tableId).FirstOrDefault();
                if (table != null)
                {
                    table.IsAvailable = true;
                    string newJson = JsonSerializer.Serialize(list);
                    File.WriteAllText(fileName, newJson);
                    return true;
                }
            }
            return false;
        }
        public List<Table> LoadTable()
        {
            string fileName = "..\\..\\..\\Json\\Table.json";
            string jsonString = File.ReadAllText(fileName);
            List<Table> list = JsonSerializer.Deserialize<List<Table>>(jsonString)!;

            return list;
        }

    }
}
