// SalesPage.xaml.cs
using PocCleanMVVM.Presentation.ViewModels;

namespace PocCleanMVVM.Presentation.Views
{
    public partial class SalesPage : ContentPage
    {
        public SalesPage(SalesViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}