using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Visa : ICreditCard
    {
        private int count = 0;

        public string Charge()
        {
            return "Charging with the Visa!";
        }

        public int Count()
        {
            count += 1;
            return count;
        }  
    }
}
