using Microsoft.Practices.Unity;
using ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityIoC
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 create the container
            var container = new UnityContainer();

            // 2 bind/map our dependencies
            container.RegisterType<ICreditCard, Visa>(new ContainerControlledLifetimeManager());

            // 3 bind to self
            container.RegisterType<Shopper, Shopper>();
            

            // 4 lifetime and scope

            Shopper shopper = container.Resolve<Shopper>();
            shopper.Charge();
            shopper.IterateCounter();

            Shopper shopper1 = container.Resolve<Shopper>();
            shopper1.Charge();
            shopper1.IterateCounter();

            Console.ReadKey();
        }
    }
}
