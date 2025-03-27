// Presentation Layer (ViewModel)
using System.Collections.ObjectModel;
using System.ComponentModel;
using AppCore.Sales;
using Domain.Entities;

namespace PocCleanMVVM.Presentation.ViewModels
{
    /// <summary>
    /// ViewModel para gestionar la lógica de la vista de ventas.
    /// Implementa INotifyPropertyChanged para notificar cambios en las propiedades.
    /// </summary>
    public class SalesViewModel : INotifyPropertyChanged
    {
        private readonly GetProductsUseCase _getProductsUseCase;
        private readonly ProcessSaleUseCase _processSaleUseCase;

        /// <summary>
        /// Colección observable de productos disponibles para la venta.
        /// </summary>
        public ObservableCollection<Product> Products { get; set; } = new();

        /// <summary>
        /// Evento que se dispara cuando una propiedad cambia.
        /// Implementa INotifyPropertyChanged.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Constructor de la clase SalesViewModel.
        /// Inicializa los casos de uso y carga los productos disponibles.
        /// </summary>
        /// <param name="getProductsUseCase">Caso de uso para obtener los productos.</param>
        /// <param name="processSaleUseCase">Caso de uso para procesar una venta.</param>
        public SalesViewModel(GetProductsUseCase getProductsUseCase, ProcessSaleUseCase processSaleUseCase)
        {
            _getProductsUseCase = getProductsUseCase;
            _processSaleUseCase = processSaleUseCase;
            LoadProducts();
        }

        /// <summary>
        /// Carga los productos disponibles utilizando el caso de uso correspondiente.
        /// </summary>
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