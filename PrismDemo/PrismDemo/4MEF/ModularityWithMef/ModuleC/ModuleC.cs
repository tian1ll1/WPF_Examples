// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Logging;
using Microsoft.Practices.Prism.MefExtensions.Modularity;
using Microsoft.Practices.Prism.Modularity;
using ModuleTracking;

namespace ModularityWithMef.Desktop
{
    /// <summary>
    /// A module for the quickstart.
    /// </summary>
    [ModuleExport(typeof(ModuleC), InitializationMode = InitializationMode.WhenAvailable)]
    public class ModuleC : IModule
    {
        private readonly IModuleTracker moduleTracker;

        private readonly ILoggerFacade logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="ModuleC"/> class.
        /// </summary>
        /// <param name="moduleTracker">The module tracker.</param>
        [ImportingConstructor]
        public ModuleC(ILoggerFacade logger, IModuleTracker moduleTracker)
        {
            if (moduleTracker == null)
            {
                throw new ArgumentNullException("moduleTracker");
            }

            this.moduleTracker = moduleTracker;
            this.moduleTracker.RecordModuleConstructed(WellKnownModuleNames.ModuleC);

            if (logger == null)
            {
                throw new ArgumentNullException("logger");
            }

            this.logger = logger;
        }

        /// <summary>
        /// Notifies the module that it has be initialized.
        /// </summary>
        public void Initialize()
        {
            this.logger.Log("ModuleA demonstrates logging during Initialize().", Category.Info, Priority.Medium);
            this.moduleTracker.RecordModuleInitialized(WellKnownModuleNames.ModuleC);
        }
    }
}
