using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;

namespace WpfModule.Modules
{
    public class OrderModule:IModule
    {
        private readonly IRegionManager regionManager;
        private readonly IUnityContainer container;

        public OrderModule(IUnityContainer container, IRegionManager regionManager)
        {
            this.container = container;
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
           // this.container.RegisterType<IOrdersRepository, OrdersRepository>(new ContainerControlledLifetimeManager());
            this.container.RegisterType<WpfModule.Services.Order>(new ContainerControlledLifetimeManager());
            // Show the Orders Editor view in the shell's main region.
            //this.regionManager.RegisterViewWithRegion("MainRegion",
            //                                           () => this.container.Resolve<WpfModule.OrderView>());

            this.regionManager.RegisterViewWithRegion("SecondRegion", ()=>this.container.Resolve<WpfModule.Views.NewView>());
        }
    }
}
