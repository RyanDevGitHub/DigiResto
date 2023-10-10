using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DigiRestoProjet.Model
{
    public class Category
    {
        //attribut property
        [JsonProperty]
        private string _name;
        [JsonProperty]
        private Color _backgroundColor;
        [JsonProperty]
        private List<Article> _articleList;
        private List<Menu> _menuList;

        public string Name {
            get { return _name;}
            set { _name= value;}
        }
        public Color BackgroundColor
        {
            get { return _backgroundColor; }
            set { _backgroundColor = value; }
        }
        public List<Article> ArticleList {
            get { return _articleList;}
            set { _articleList = value; }
        }
        public List<Menu> MenuList
        {
            get { return _menuList;}
            set { _menuList = value; }
        }
        //constructor
        [Newtonsoft.Json.JsonConstructor]
        public Category(string name ,List<Article> articleList,Color color,List<Menu> menuList) {
        
            _name = name;
            _articleList = new List<Article>();
            if(menuList != null)
            {
                _menuList = menuList;
            }
            else
            {
                _menuList = new List<Menu>();
            }
            if (color.IsEmpty)
            {
                color = Color.FromArgb(Random.Shared.Next(50, 255), Random.Shared.Next(50, 255), Random.Shared.Next(50, 255));
            }
            _backgroundColor = color;

            foreach ( Article item in articleList)
            {
                _articleList.Add(item);
            }

            //if (menuList != null)
            //{
            //    foreach (Menu item in menuList)
            //    {
            //        _menuList.Add(item);
            //    }
            //}
 
        }

        
        public Category(string name, List<Article> articleList, Color color)
        {
            _name = name;
            _articleList = new List<Article>();
            if(color.IsEmpty)
            {
                color = Color.FromArgb(Random.Shared.Next(50, 255), Random.Shared.Next(50, 255), Random.Shared.Next(50, 255));
            }
            _backgroundColor = color;


            foreach (Article item in articleList)
            {
                _articleList.Add(item);
            }

        }

    }
}
