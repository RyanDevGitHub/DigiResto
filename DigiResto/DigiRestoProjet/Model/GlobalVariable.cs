using DigiResto;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DigiRestoProjet.Model
{
    static internal class GlobalVariable
    {
        static JsonSerializer serializer = new JsonSerializer();
        static string jsonstring = "";
        public static ObservableCollection<Ingredient> ingredientList = GlobalVariable.DeserializedIngredientJson();
        public static ObservableCollection<Article> articleList = GlobalVariable.DeserializedArticleJson();
        public static ObservableCollection<Table> tableList = GlobalVariable.DeserializedTableJson();
        public static ObservableCollection<Menu> menuList = GlobalVariable.DeserializedMenuJson();
        public static ObservableCollection<Category> categoryList = GlobalVariable.DeserializedCategoryJson();
        public static ObservableCollection<Stock> stockList = GlobalVariable.DeserializedStockJson();
        public static Task myTask4 = Task.Run(() => { tableList = GlobalVariable.DeserializedTableJson(); });
        public static Task myTask5 = Task.Run(() => { menuList = GlobalVariable.DeserializedMenuJson(); });
        public static Task myTask6 = Task.Run(() => { categoryList = GlobalVariable.DeserializedCategoryJson(); });
        public static string basepath = "";
        public static IdCounter idCounterTable;
        public static IdCounter idCounterStock;
        public static IdCounter idCounterArticle;
        public static IdCounter idCounterCategory;
        public static IdCounter idCounterIngredient;
        public static List<IdCounter> idCounterList;
        //transform List<Stock> to Json string
        public static string SerializeStockJson()
        {
            jsonstring = JsonConvert.SerializeObject(stockList, Formatting.Indented);
            return jsonstring;

        }

        //transform file json to List<Stock>
        public static ObservableCollection<Stock> DeserializedStockJson()
        {
            basepath = Directory.GetParent(System.Environment.CurrentDirectory).Parent.Parent.FullName;
            string fileName = basepath + "\\Json\\Stock.json";
            if (File.Exists(fileName))
            {
                var StockList = JsonConvert.DeserializeObject<ObservableCollection<Stock>>(File.ReadAllText(fileName));
                return StockList;
            }
            return null;
        }



        // export string in json file 
        public static void ExportStockJson()
        {
            basepath = Directory.GetParent(System.Environment.CurrentDirectory).Parent.Parent.FullName;
            using (var streamWriter = new StreamWriter(basepath + "\\Json\\Stock.json"))
            {
                using (var jsonWriter = new JsonTextWriter(streamWriter))
                {
                    jsonWriter.Formatting = Formatting.Indented;
                    serializer.Serialize(jsonWriter, JsonConvert.DeserializeObject(jsonstring));
                }
            }

        }

        //transform List<Categorys> to Json string
        public static string SerializeCategoryJson()
        {
            jsonstring = JsonConvert.SerializeObject(categoryList, Formatting.Indented);
            return jsonstring;

        }

        //transform file json to List<Category>

        public static ObservableCollection<Category> DeserializedCategoryJson()
        {
            basepath = Directory.GetParent(System.Environment.CurrentDirectory).Parent.Parent.FullName;
            string fileName = basepath + "\\Json\\Category.json";
            if (File.Exists(fileName))
            {
                var categoryList = JsonConvert.DeserializeObject<ObservableCollection<Category>>(File.ReadAllText(fileName));
                return categoryList;
            }
            return null;
        }


        // export write string in file category json
        public static void ExportCategoryJson()
        {
            basepath = Directory.GetParent(System.Environment.CurrentDirectory).Parent.Parent.FullName;
            using (var streamWriter = new StreamWriter(basepath + "\\Json\\Category.json"))
            {
                using (var jsonWriter = new JsonTextWriter(streamWriter))
                {
                    jsonWriter.Formatting = Formatting.Indented;
                    serializer.Serialize(jsonWriter, JsonConvert.DeserializeObject(jsonstring));
                }
            }

        }



        //transform List<Ingredient> to Json string
        public static string SerializeIngredientJson()
        {
            jsonstring = JsonConvert.SerializeObject(ingredientList, Formatting.Indented);
            return jsonstring;

        }

        //transform file json to List<Ingredient>
        public static ObservableCollection<Ingredient> DeserializedIngredientJson()
        {
            basepath = Directory.GetParent(System.Environment.CurrentDirectory).Parent.Parent.FullName;
            string fileName = basepath + "\\Json\\Ingredient.json";
            if (File.Exists(fileName))
            {
                var IngredientList = JsonConvert.DeserializeObject<ObservableCollection<Ingredient>>(File.ReadAllText(fileName));
                return IngredientList;
            }
            return null;
        }

        // export write string in file
        public static void ExportIngredientJson()
        {
            basepath = Directory.GetParent(System.Environment.CurrentDirectory).Parent.Parent.FullName;
            using (var streamWriter = new StreamWriter(basepath + "\\Json\\Ingredient.json"))
            {
                using (var jsonWriter = new JsonTextWriter(streamWriter))
                {
                    jsonWriter.Formatting = Formatting.Indented;
                    serializer.Serialize(jsonWriter, JsonConvert.DeserializeObject(jsonstring));
                }
            }

        }

        //transform List<Article> to Json string
        public static string SerializeArticleJson()
        {
            jsonstring = JsonConvert.SerializeObject(articleList, Formatting.Indented);
            return jsonstring;

        }

        //transform file json to List<Ingredient>
        public static ObservableCollection<Article> DeserializedArticleJson()
        {
            basepath = Directory.GetParent(System.Environment.CurrentDirectory).Parent.Parent.FullName;
            string fileName = basepath + "\\Json\\Article.json";
            if (File.Exists(fileName))
            {
                var articleList = JsonConvert.DeserializeObject<ObservableCollection<Article>>(File.ReadAllText(fileName));
                return articleList;
            }
            return null;
        }



        // export write string in file
        public static void ExportArticleJson()
        {
            basepath = Directory.GetParent(System.Environment.CurrentDirectory).Parent.Parent.FullName;
            using (var streamWriter = new StreamWriter(basepath + "\\Json\\Article.json"))
            {
                using (var jsonWriter = new JsonTextWriter(streamWriter))
                {
                    jsonWriter.Formatting = Formatting.Indented;
                    serializer.Serialize(jsonWriter, JsonConvert.DeserializeObject(jsonstring));
                }
            }

        }
        //transform List<Table> to Json string
        public static string SerializeTableJson()
        {
            jsonstring = JsonConvert.SerializeObject(tableList, Formatting.Indented);
            return jsonstring;

        }

        //transform file json to List<Table>
        public static ObservableCollection<Table> DeserializedTableJson()
        {
            basepath = Directory.GetParent(System.Environment.CurrentDirectory).Parent.Parent.FullName;
            string fileName = basepath + "\\Json\\Table.json";
            if (File.Exists(fileName))
            {
                var tableList = JsonConvert.DeserializeObject<ObservableCollection<Table>>(File.ReadAllText(fileName));
                return tableList;
            }
            return null;
        }

        // export write string in file
        public static void ExportMenuJson()
        {
            basepath = Directory.GetParent(System.Environment.CurrentDirectory).Parent.Parent.FullName;
            using (var streamWriter = new StreamWriter(basepath + "\\Json\\Menu.json"))
            {
                using (var jsonWriter = new JsonTextWriter(streamWriter))
                {
                    jsonWriter.Formatting = Formatting.Indented;
                    serializer.Serialize(jsonWriter, JsonConvert.DeserializeObject(jsonstring));
                }
            }

        }
        //transform List<Table> to Json string
        public static string SerializeMenuJson()
        {
            jsonstring = JsonConvert.SerializeObject(menuList, Formatting.Indented);
            return jsonstring;

        }

        //transform file json to List<Table>
        public static ObservableCollection<Menu> DeserializedMenuJson()
        {
            basepath = Directory.GetParent(System.Environment.CurrentDirectory).Parent.Parent.FullName;
            string fileName = basepath + "\\Json\\Menu.json";
            if (File.Exists(fileName))
            {
                var menuList = JsonConvert.DeserializeObject<ObservableCollection<Menu>>(File.ReadAllText(fileName));
                return menuList;
            }
            return null;
        }



        // export write string in file
        public static void ExportTableJson()
        {
            using (var streamWriter = new StreamWriter(basepath + "\\Json\\Table.json"))
            {
                using (var jsonWriter = new JsonTextWriter(streamWriter))
                {
                    jsonWriter.Formatting = Formatting.Indented;
                    serializer.Serialize(jsonWriter, JsonConvert.DeserializeObject(jsonstring));
                }
            }

        }
        public static void InitIdCounter() {
            if (idCounterList != null) return;
            if (File.Exists(basepath + "IdCounter.json") == false)
            {
                basepath = Directory.GetParent(System.Environment.CurrentDirectory).Parent.Parent.FullName;
                File.Create(basepath + "\\Json\\IdCounter.json").Close();
                idCounterList = new List<IdCounter>();
                idCounterTable = new IdCounter("Table");
                GlobalVariable.idCounterList.Add(idCounterTable);
                idCounterStock = new IdCounter("Stock");
                GlobalVariable.idCounterList.Add(idCounterStock);
                idCounterArticle = new IdCounter("Article");
                GlobalVariable.idCounterList.Add(idCounterArticle);
                idCounterCategory = new IdCounter("Category");
                GlobalVariable.idCounterList.Add(idCounterCategory);
                idCounterIngredient = new IdCounter("Ingredient");
                GlobalVariable.idCounterList.Add(idCounterIngredient);

            }
            else
            {
               idCounterList = GlobalVariable.DeserializedIdCounterJson();
            }
        }
        //transform List<IdCounter> to Json string
        public static string SerializeIdCounterJson()
        {
            jsonstring = JsonConvert.SerializeObject(idCounterList, Formatting.Indented);
            return jsonstring;

        }

        //transform file json to List<IdCounter>
        public static List<IdCounter> DeserializedIdCounterJson()
        {
            basepath = Directory.GetParent(System.Environment.CurrentDirectory).Parent.Parent.FullName;
            string fileName = basepath + "\\Json\\IdCounter.json";
            if (File.Exists(fileName))
            {
                var idCounterLists = JsonConvert.DeserializeObject<List<IdCounter>>(File.ReadAllText(fileName));
                return idCounterLists;
            }
            return null;
        }



        // export write string in file
        public static void ExportIdCounterJson()
        {
            basepath = Directory.GetParent(System.Environment.CurrentDirectory).Parent.Parent.FullName;
            using (var streamWriter = new StreamWriter(basepath + "\\Json\\IdCounter.json"))
            {
                using (var jsonWriter = new JsonTextWriter(streamWriter))
                {
                    jsonWriter.Formatting = Formatting.Indented;
                    serializer.Serialize(jsonWriter, JsonConvert.DeserializeObject(jsonstring));
                }
            }

        }
    }
}
