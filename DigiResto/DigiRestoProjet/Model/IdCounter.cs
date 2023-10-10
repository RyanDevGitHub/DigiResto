using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiRestoProjet.Model
{
    internal class IdCounter
    {
        private string _name;
        public string Name
        { 
            get { return _name; }
            set { _name = value; }

        }
        private int _value;
        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }
        public IdCounter(string Name) { 
            _name= Name;
            _value= 0;
        }  
    }
}
