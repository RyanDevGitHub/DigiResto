using DigiRestoProjet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiResto.Model
{
    internal class Order
    {
        //attribut
        int IdOrder;
        List<Item> ItemList;
        DateTime OrderDate;
        User Cashier;
        int NumberCustum;
        Table table;
        double PriceTotal;
        DateTime DateCheckout;

        //constructeur
        Order() { }

        //methode
        void AddItem()
        {

        }
        void RemoveItem()
        {

        }
        void ChooseTakeAway()
        {

        }
        void AddTable()
        {
                
        }
        double ComputePrice()
        {
            double price = 0;
            return price;
        }
        void PrintTicket()
        {

        }
    }
}

