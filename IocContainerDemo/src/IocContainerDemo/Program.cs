using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ShoppingCart;

namespace IocContainerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Shopper shopper = new Shopper(new MasterCard());
            shopper.Charge();

            //// configuration
            //var container = new Resolver();
            //container.Register<Shopper, Shopper>();
            ////container.Register<ICreditCard, Visa>();

            //// get to the Shoppa!
            //Shopper shopper = container.Resolve<Shopper>();
            //shopper.Charge();

            Console.ReadKey();
        }
    }
}
