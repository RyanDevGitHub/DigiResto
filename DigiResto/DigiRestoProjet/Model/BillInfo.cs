using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiRestoProjet.Model
{
    public class BillInfo
    {
        public int Id { get; set; }
        public int BillId { get; set; }
        public List<FoodQuantity>? Food { get; set; }
        public List<ArticleMenu>? Menu { get; set; } 
    }
}
