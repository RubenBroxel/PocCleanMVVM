// WarehousePage.xaml.cs
using PocCleanMVVM.Presentation.ViewModels;

namespace PocCleanMVVM.Presentation.Views
{
    public partial class WarehousePage : ContentPage
    {
        public WarehousePage(WarehouseViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}