using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ninject;
using ShoppingCart;

namespace NinjectIoc
{
    class Program
    {
        static void Main(string[] args)
        {
            // create the kernel
            var kernel = new StandardKernel();
            
            // bind/map our dependencies
            kernel.Bind<ICreditCard>().To<Visa>();

            Shopper shopper = kernel.Get<Shopper>();
            shopper.Charge();
            shopper.IterateCounter();

            Shopper shopper1 = kernel.Get<Shopper>();
            shopper1.Charge();
            shopper1.IterateCounter();

            Console.ReadKey();
        }
    }
}
