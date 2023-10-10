using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DigiRestoProjet.Model.custom_control
{
    public class CCBoxItem
    {
        private object val;
        public object Value
        {
            get { return val; }
            set { val = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public CCBoxItem()
        {
        }

        public CCBoxItem(string name, object val)
        {
            this.name = name;
            this.val = val;
        }

        public override string ToString()
        {
            return string.Format("name: '{0}', value: {1}", name, val);
        }
    }
}
