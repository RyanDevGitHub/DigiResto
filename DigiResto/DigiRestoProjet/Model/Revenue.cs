using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiRestoProjet.Model
{
    public class Revenue
    {
        public int year { get; set; }
        public List<RevenueByMonth> total { get; set; }
        public float sum { get; set; }
    }
}
