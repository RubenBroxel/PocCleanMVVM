// PurchasePage.xaml.cs
using PocCleanMVVM.Presentation.ViewModels;

namespace PocCleanMVVM.Presentation.Views
{
    public partial class PurchasePage : ContentPage
    {
        public PurchasePage(PurchaseViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }

}


