using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiRestoProjet.Model
{
    public class Bill
    {
        public int Id { get; set; }
        public int TableId { get; set; }
        public DateTime DateCheckIn { get; set; }
        public DateTime DateCheckOut  { get; set; }
        public float Total { get; set; }
        public bool IsCheckOut { get; set; }
        public string PaymentMethod { get; set; }
        public string Manage { get; set; }
    }
}
