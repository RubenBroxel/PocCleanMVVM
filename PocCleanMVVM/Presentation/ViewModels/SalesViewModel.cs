// Presentation Layer (ViewModel)
using System.Collections.ObjectModel;
using System.ComponentModel;
using AppCore.Sales;
using Domain.Entities;

namespace PocCleanMVVM.Presentation.ViewModels
{
    public class SalesViewModel : INotifyPropertyChanged
    {
        private readonly GetProductsUseCase _getProductsUseCase;
        private readonly ProcessSaleUseCase _processSaleUseCase;
        
        public ObservableCollection<Product> Products { get; set; } = new();
        public event PropertyChangedEventHandler? PropertyChanged;
        
        public SalesViewModel(GetProductsUseCase getProductsUseCase, ProcessSaleUseCase processSaleUseCase)
        {
            _getProductsUseCase = getProductsUseCase;
            _processSaleUseCase = processSaleUseCase;
            LoadProducts();
        }
        
        private async void LoadProducts()
        {
            var products = await _getProductsUseCase.ExecuteAsync();
            foreach (var product in products)
            {
                Products.Add(product);
            }
        }
    }
}
