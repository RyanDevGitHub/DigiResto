using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiRestoProjet.Model
{
    public class Menu 
    {
        [JsonProperty]
        private string _name;
        public string Name { 
            get { return _name; } 
            set { _name = value; }
        }
        [JsonProperty]
        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        [JsonProperty]
        private double _price;
        public double Price { 
            get { return _price;} 
            set { _price = value; } 
        }
        [JsonProperty]
        private ObservableCollection<Article> _enterArticle;
        public ObservableCollection<Article> EnterArticle { 
            get { return _enterArticle; } 
            set { _enterArticle = value; } 
        }
        [JsonProperty]
        private ObservableCollection<Article> _dishArticle;
        public ObservableCollection<Article> DishArticle
        {
            get { return _dishArticle; }
            set { _dishArticle = value; }
        }
        [JsonProperty]
        private ObservableCollection<Article> _dessertArticle;
        public ObservableCollection<Article> DessertArticle
        {
            get { return _dessertArticle; }
            set { _dessertArticle = value; }
        }

        [JsonConstructor]
        public Menu(string name,string description, double price, ObservableCollection<Article> enter , ObservableCollection<Article> dish, ObservableCollection<Article> dessert)
        {
            _name = name;
            _price = price;
            _description = description;
            _enterArticle = enter;
            _dishArticle = dish;
            _dessertArticle = dessert;
        }
    }
}
