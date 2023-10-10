using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiRestoProjet
{
    public class Config
    {
        private  static Config _instance;
        public static Config Instance {
            get { 
                if (_instance == null) { 
                    _instance = new Config(); 
                }
                return _instance;
            }
        }
        private string _category_Location;
        public string Category_Locaton
        {
            get
            {
                return "\\Json\\Stock.json";
            }
        }
        private string _ingredient_Location;
        public string Ingredient_Locaton
        {
            get
            {
                return "\\Json\\Ingredient.json";
            }
        }
        private string _article_Location;
        public string Article_Locaton
        {
            get
            {
                return "\\Json\\Article.json";
            }
        }
        private string _stock_Location;
        public string Stock_Locaton
        {
            get
            {
                return "\\Json\\Stock.json";
            }
        }
        private string _table_Location;
        public string Table_Locaton
        {
            get
            {
                return "\\Json\\Table.json";
            }
        }


        private Config()
        {
            
        }

         

    }
}
