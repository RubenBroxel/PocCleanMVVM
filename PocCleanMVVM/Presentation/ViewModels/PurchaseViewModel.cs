// PurchaseViewModel.cs (Presentation Layer)
using AppCore.Purchase;
using Domain.Entities;
using System.Collections.ObjectModel;
using System.Windows.Input;
//using CommunityToolkit.Mvvm.Input;
namespace PocCleanMVVM.Presentation.ViewModels
{
    public class PurchaseViewModel
    {
        private readonly GetPurchaseOrdersUseCase _getOrdersUseCase;
        private readonly AddPurchaseOrderUseCase _addOrderUseCase;
        public ObservableCollection<PurchaseOrder> PurchaseOrders { get; } = new();
        public ICommand AddPurchaseCommand { get; }
        
        public PurchaseViewModel(GetPurchaseOrdersUseCase getOrdersUseCase, AddPurchaseOrderUseCase addOrderUseCase)
        {
            _getOrdersUseCase = getOrdersUseCase;
            _addOrderUseCase = addOrderUseCase;
            //AddPurchaseCommand = new RelayCommand(AddPurchase);
        }
        
        public async void LoadOrders()
        {
            var orders = await _getOrdersUseCase.Execute();
            PurchaseOrders.Clear();
            foreach (var order in orders)
                PurchaseOrders.Add(order);
        }
        
        private async void AddPurchase()
        {
            var newOrder = new PurchaseOrder { Supplier = "Nuevo Proveedor", TotalAmount = 100.00m };
            await _addOrderUseCase.Execute(newOrder);
            LoadOrders();
        }
    }
}
