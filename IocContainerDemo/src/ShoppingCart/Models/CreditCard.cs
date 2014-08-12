using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class CreditCard : ICreditCard
    {
        private string name = "";
        private int count = 0;

        public CreditCard()
            : this("Dummy")
        {
        }

        public CreditCard(string name)
        {
            this.name = name;
        }

        public string Charge()
        {
            return string.Format("Swiping the {0}!", name);
        }

        public int Count()
        {
            count += 1;
            return count;
        }
    }
}
