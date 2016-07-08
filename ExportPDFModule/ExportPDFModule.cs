using ExportPDFModule.Views;
using Infrastructure.Core;
using Infrastructure.Interfaces;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportPDFModule
{
    public class ExportPDFModule : IModule
    {
        private readonly IUnityContainer _container;
        private readonly IRegionManager _manager;

        public ExportPDFModule(IUnityContainer container, IRegionManager manager)
        {
            _container = container;
            _manager = manager;
        }

        public void Initialize()
        {
            _container.RegisterType<IViewModel, ViewModels.MainExpPDFViewModel>("MainExpPDFViewModel");
            var view = _container.Resolve<Views.MainExpPDF>();
            _manager.Regions[RegionNames.MainContentRegion].Add(view);

            var navView = _container.Resolve<NavExpPDF>();
            _manager.Regions[RegionNames.AccueilRegion].Add(navView);
        }
    }
}
