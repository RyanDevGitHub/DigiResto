using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DigiRestoProjet.Model
{
    public class Ingredient
    {
        //attribut property
        [JsonProperty]
        private string _name;

        public string Name { 
            
            get {return _name;}
            set { _name = value; }
        
        }

        [JsonProperty]
        private DateTime _date_of_peremption;

        public DateTime Date_of_peremption
        {
            get { return _date_of_peremption; }
            set { _date_of_peremption = value; }
        }

        private int _quantity;
         public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        private Units _unity;

        public Units Unity
        {
            get { return _unity; }
            set { _unity = value; }
        }
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }





        //constructor
        [Newtonsoft.Json.JsonConstructor]
        public Ingredient(string name , DateTime date_of_peremption,Units unity) {
            _unity = unity;
            _name = name ;
            _date_of_peremption = date_of_peremption;
        }
        public Ingredient(string name, int quantity, Units unity)
        {
            _unity = unity;
            _name = name ;     
            _quantity = quantity;
        }

        //methode

    }
}
