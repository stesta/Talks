using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCart;

using Ninject;
using Ninject.Modules;
using Ninject.Extensions.Xml;
using Ninject.Extensions.Conventions;

namespace NinjectIoc
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 create the kernel
            // 2 bind/map our dependencies
            // 3 rebind
            // 4 bind to self
            // 5 property injection
            // 6 lifetime and scope
            // 7 modules
            // 8 xml config
            // 9 conventions


            //Shopper shopper = kernel.Get<Shopper>();
            //shopper.Charge();
            //shopper.IterateCounter();

            //Shopper shopper1 = kernel.Get<Shopper>();
            //shopper1.Charge();
            //shopper1.IterateCounter();

            Console.ReadKey();
        }

        //public class ShopperModule : NinjectModule
        //{

        //    public override void Load()
        //    {
        //        Bind<ICreditCard>().To<Visa>();
        //        //Rebind<ICreditCard>().To<MasterCard>().InSingletonScope();
        //    }
        //}
    }
}
