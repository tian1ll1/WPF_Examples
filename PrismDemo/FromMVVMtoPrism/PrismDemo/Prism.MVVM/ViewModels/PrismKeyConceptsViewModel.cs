using System.Collections.Generic;
using Microsoft.Practices.Prism.Mvvm;

namespace PrismDemo.Mvvm.ViewModels
{
    public class PrismKeyConceptsViewModel : BindableBase
    {
        public PrismKeyConceptsViewModel()
        {
            this.KeyConcepts = new[] { "Modules", 
                "Module catalog", 
                "Shell", "Views", 
                "View models", 
                "Models", 
                "Commands",
                "Regions", 
                "Navigation" ,
                "EventAggregator",
                "Dependency injection container",
                "Services",
                "Controllers",
                "Bootstrapper"
            };
        }
        public IEnumerable<string> KeyConcepts { get; private set; }
    }
}
