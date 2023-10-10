using DigiRestoProjet.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DigiRestoProjet.Service
{
    public class StorageService
    {
        private static StorageService _instance;
        public static StorageService Instance { 
            get {
                if(_instance == null)
                {
                    _instance = new StorageService();
                }
                return _instance;
            }
        }

        public ObservableCollection<Category> category { get; private set; }


        private StorageService() {
            // init des trucs
            //category = load(Config.Instance.Category_Locaton);

        }
        /*
        private ObservableCollection<T> load(string path)
        {
            string basepath = Directory.GetParent(System.Environment.CurrentDirectory).Parent.Parent.FullName;
            string fileName = basepath + path;
            if (File.Exists(fileName))
            {
                var categoryList = JsonConvert.DeserializeObject<ObservableCollection<Category>>(File.ReadAllText(fileName));
                return categoryList;
            }
            return null;
        }*/


    }
}
