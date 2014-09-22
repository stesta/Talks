using Ninject;
using ShoppingCart;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WPFApplication
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            using (var kernel = new StandardKernel())
            {
                kernel.Bind<ICreditCard>().To<MasterCard>();
                
                var mainWindow = kernel.Get<MainWindow>();
                mainWindow.Show();
            }
        }
    }
}
