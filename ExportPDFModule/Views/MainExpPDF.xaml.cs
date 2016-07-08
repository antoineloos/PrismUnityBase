using Infrastructure.Interfaces;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExportPDFModule.Views
{
    /// <summary>
    /// Interaction logic for MainExpPDF.xaml
    /// </summary>
    public partial class MainExpPDF : IView
    {
        public MainExpPDF([Dependency("MainExpPDFViewModel")]IViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;
        }




        public IViewModel ViewModel
        {
            get { return (IViewModel)DataContext; }
            set { DataContext = value; }
        }


        public string Header
        {
            get
            {
                return ViewModel.Header;
            }
            set
            {
                ViewModel.Header = value;
            }
        }
    }
}
