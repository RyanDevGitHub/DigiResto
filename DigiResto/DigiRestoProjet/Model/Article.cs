using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiRestoProjet.Model
{
    public class Article
    {

        //attribut property
        [JsonProperty]
        private int _id;
        [JsonProperty]
        private string _name;
        [JsonProperty]
        private string _description;
        [JsonProperty]
        private double _price;
        [JsonProperty]
        private DateTime _date_of_peremption;
        [JsonProperty]
        public List<Ingredient> _ingredientList = new List<Ingredient>();

        public int Id 
        { 
            get { return _id; } 
            set { _id = value; } 
        }
        public string Name
        {
            get {return _name; }
            set { _name = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public DateTime Date_of_peremption
        {
            get { return _date_of_peremption; }
            
        }

        //constructor
        public Article(string name,string description ,double price, List<Ingredient> ingredientList ) {
            _name = name;
            _description = description;
            _price = price;
            _ingredientList = ingredientList;  
        }
        

        //methode

    }
}
