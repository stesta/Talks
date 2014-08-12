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
    public class Working
    {
        public Working ()
	    {
            // 1 create the kernel
            var kernel = new StandardKernel();

            kernel.Bind<ICreditCard>().To<Visa>();
            kernel.Bind<ICreditCard>().To<MasterCard>().InSingletonScope();
            kernel.Bind<Shopper>().ToSelf().InSingletonScope();


            // 5 modules
            kernel.Load(new WorkingModule());

            // 6 xml config
            kernel.Load(Helpers.AssemblyDirectory + "\\*.xml");

            // 7 conventions
            kernel.Bind(x => x
                              .FromAssembliesInPath(Helpers.AssemblyDirectory)
                              .SelectAllClasses()
                              .InheritedFrom<ICreditCard>()
                              .BindDefaultInterfaces()
                              .Configure(b => b.InSingletonScope()
                                               .WithConstructorArgument("name", "BackupCard"))
                              //.ConfigureFor<Shopper>(b => b.InThreadScope())
                        );
	    }
    }

    public class WorkingModule : NinjectModule
    {
        public override void Load()
        {
            Rebind<ICreditCard>().To<Visa>();
            Rebind<ICreditCard>().To<MasterCard>().InSingletonScope();
        }
    }
}
