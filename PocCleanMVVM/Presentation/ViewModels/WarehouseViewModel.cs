// WarehouseViewModel.cs (Presentation Layer)
using AppCore.Warehouse;
using Domain.Entities;
using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace PocCleanMVVM.Presentation.ViewModels
{
    public class WarehouseViewModel
    {
        private readonly GetWarehouseItemsUseCase _getItemsUseCase;
        private readonly AddWarehouseItemUseCase _addItemUseCase;
        public ObservableCollection<WarehouseItem> WarehouseItems { get; } = new();
        public ICommand AddItemCommand { get; }
        
        public WarehouseViewModel(GetWarehouseItemsUseCase getItemsUseCase, AddWarehouseItemUseCase addItemUseCase)
        {
            _getItemsUseCase = getItemsUseCase;
            _addItemUseCase = addItemUseCase;
            AddItemCommand = new RelayCommand(AddItem);
        }
        
        public async void LoadItems()
        {
            var items = await _getItemsUseCase.Execute();
            WarehouseItems.Clear();
            foreach (var item in items)
                WarehouseItems.Add(item);
        }
        
        private async void AddItem()
        {
            var newItem = new WarehouseItem { Name = "Nuevo Item", Quantity = 10 };
            await _addItemUseCase.Execute(newItem);
            LoadItems();
        }
    }
}
