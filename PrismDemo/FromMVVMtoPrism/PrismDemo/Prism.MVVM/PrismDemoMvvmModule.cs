using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Prism.MefExtensions.Modularity;

namespace PrismDemo.Mvvm
{
    public class PrismDemoMvvmModule : IModule
    {
        private readonly IRegionManager regionManager;

        public PrismDemoMvvmModule(IRegionManager registry)
        {
            this.regionManager = registry;
        }

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.MvvmMain));
            regionManager.RegisterViewWithRegion("PrismKeyConceptsRegion", typeof(Views.PrismKeyConcepts));
        }
    }
}
