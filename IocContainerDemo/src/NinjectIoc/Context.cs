using Ninject;
using ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectIoc
{
    public class Context
    {
        #region Singleton Setup

        // sets up the singleton
        private static readonly Lazy<Context> lazy = new Lazy<Context>(() => new Context());

        // The instance of the context object
        public static Context Instance { get { return lazy.Value; } }

        #endregion

        private Context()
        {
            InitializeKernel();
        }

        public IKernel Kernel { get; private set; }
        private void InitializeKernel()
        {
            Kernel = new StandardKernel();

            Kernel.Bind<ICreditCard>().To<Visa>().InSingletonScope();
        }
    }
}
