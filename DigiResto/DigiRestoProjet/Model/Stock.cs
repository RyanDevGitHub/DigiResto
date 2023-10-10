using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DigiRestoProjet.Model
{
    [JsonObject(MemberSerialization.OptIn)]
    partial class Stock
    {
        //attribut
        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty]
        public int Quantity { get; set; }

        [JsonProperty]
        public Units Unity { get; set; }

        [JsonProperty]
        public DateTime DateOfPeremption { get; set; }



        //constructor
        public Stock(string name, int quantity, Units unity, DateTime dateOfPeremption)
        {
            Name = name;
            Quantity = quantity;
            Unity = unity;
            DateOfPeremption = dateOfPeremption;
            

        }

        //methodes

        public override string ToString()
        {
            return "Name: " + Name + "Quantity " + Quantity + "date of peremption" + DateOfPeremption;
        }
    }
}

