using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiRestoProjet.Model
{
    public class ArticleInCommand
    {
        public int ArticleId { get; set; }
        public string ArticleName { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
    }
}
