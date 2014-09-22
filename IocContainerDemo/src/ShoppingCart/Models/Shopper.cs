using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Shopper
    {
        private ICreditCard _creditCard;

        public Shopper(ICreditCard creditCard)
        {
            _creditCard = creditCard;
        }

        //[]
        //public ICreditCard CreditCard { get { return _creditCard; } set { _creditCard = value; } }

        public void Charge()
        {
            var chargeMessage = _creditCard.Charge();
            Console.WriteLine(chargeMessage);
        }

        public void IterateCounter()
        {
            int count = _creditCard.Count();
            Console.WriteLine(count);
        }
    }
}
