using Infrastructure.Interfaces;
using Microsoft.Practices.ServiceLocation;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportPDFModule.ViewModels
{
    public class NavExpPDFViewModel : BindableBase
    {
        private string titre;
        public string Titre
        {
            get { return titre; }
            set { SetProperty(ref titre, value); }
        }
        public IEventAggregator _eventAggregator { get; set; }
        public DelegateCommand NavCommand { get; private set; }

        public NavExpPDFViewModel(INavMethods navMethods)
        {
            _eventAggregator = ServiceLocator.Current.GetInstance<IEventAggregator>();
            Titre = "Export PDF";
            NavCommand = new DelegateCommand(NavFunc);
        }

        private void NavFunc()
        {
            _eventAggregator.GetEvent<PubSubEvent<string>>().Publish("EXPORT PDF");
        }

    }
}
