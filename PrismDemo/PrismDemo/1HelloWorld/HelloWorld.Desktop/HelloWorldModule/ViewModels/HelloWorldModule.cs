using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;


namespace HelloWorldModule
{
    public class HelloWorldModule : IModule 
    {
        private readonly IRegionManager regionMgr;
        public void Initialize()
        {
            regionMgr.RegisterViewWithRegion("MainRegion", typeof(Views.HelloWorldView));
        }

        public HelloWorldModule(IRegionManager rm)
        {
            this.regionMgr = rm;
        }
    }
}
