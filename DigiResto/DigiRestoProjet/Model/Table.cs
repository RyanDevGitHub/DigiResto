using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiRestoProjet.Model
{
    public class Table
    {
        //property
        [JsonProperty]
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [JsonProperty]
        private string _name ;

        public string Name
        {
            get{return _name; }
            set{ _name = value; }
        }

        [JsonProperty]
        private int _size;
        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }
        private bool _isAvailable;
        public bool IsAvailable { 
            get { return _isAvailable; } 
            set {_isAvailable = value; }
        }

        //constructor

        public Table(int size) {
            var basepath = Directory.GetParent(System.Environment.CurrentDirectory).Parent.Parent.FullName;
            GlobalVariable.InitIdCounter();
            _isAvailable = true;
            _size = size;
            if (File.Exists( basepath + "\\Json\\IdCounter.json") == true)
            {
                IdCounter idCounterTable = GlobalVariable.idCounterList.Find(idCounter => idCounter.Name == GlobalVariable.idCounterTable.Name);
                _id = idCounterTable.Value;
                _name = "Table n°" + Id;
                GlobalVariable.idCounterTable.Value++;
            }
           
        }
    }
   
}
