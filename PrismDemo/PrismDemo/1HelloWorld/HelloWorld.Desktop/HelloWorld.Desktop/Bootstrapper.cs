using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Unity;

namespace HelloWorld.Desktop
{
    class Bootstrapper:UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return new Shell();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell(); 

            App.Current.MainWindow = (Window)this.Shell;
            App.Current.MainWindow.Show();

        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();

            ModuleCatalog mc = (ModuleCatalog)this.ModuleCatalog;
            mc.AddModule(typeof(HelloWorldModule.HelloWorldModule));
        }

        
    }
}
