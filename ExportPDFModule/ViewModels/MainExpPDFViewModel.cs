using Infrastructure.Interfaces;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportPDFModule.ViewModels
{
    public class MainExpPDFViewModel : BindableBase,IViewModel
    {
        private string textlb;
        public string TextLb
        {
            get { return textlb; }
            set { SetProperty(ref textlb, value); }
        }


        public string Header { get; set; }

        

        public string Title { get; set; }


        public MainExpPDFViewModel()
        {
            Header = "EXPORT PDF";
            Title = "EXPORT PDF";
            TextLb = "test";
        }


    }
}
