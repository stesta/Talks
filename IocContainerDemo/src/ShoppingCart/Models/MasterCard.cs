using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class MasterCard : ICreditCard
    {
        private int count = 0;

        public string Charge()
        {
            return "Swiping the MasterCard!";
        }

        public int Count()
        {
            count += 1;
            return count;
        }
    }
}
