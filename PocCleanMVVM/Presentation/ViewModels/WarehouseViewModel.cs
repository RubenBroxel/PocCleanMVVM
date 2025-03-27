// WarehouseViewModel.cs (Presentation Layer)
using AppCore.Warehouse;
using Domain.Entities;
using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace PocCleanMVVM.Presentation.ViewModels
{
    /// <summary>
    /// ViewModel para gestionar la lógica de la vista del almacén.
    /// Implementa la lógica para cargar y agregar elementos al almacén.
    /// </summary>
    public class WarehouseViewModel
    {
        private readonly GetWarehouseItemsUseCase _getItemsUseCase;
        private readonly AddWarehouseItemUseCase _addItemUseCase;

        /// <summary>
        /// Colección observable de elementos del almacén.
        /// </summary>
        public ObservableCollection<WarehouseItem> WarehouseItems { get; } = new();

        /// <summary>
        /// Comando para agregar un nuevo elemento al almacén.
        /// </summary>
        public ICommand AddItemCommand { get; }

        /// <summary>
        /// Constructor de la clase WarehouseViewModel.
        /// Inicializa los casos de uso y el comando AddItemCommand.
        /// </summary>
        /// <param name="getItemsUseCase">Caso de uso para obtener los elementos del almacén.</param>
        /// <param name="addItemUseCase">Caso de uso para agregar un nuevo elemento al almacén.</param>
        public WarehouseViewModel(GetWarehouseItemsUseCase getItemsUseCase, AddWarehouseItemUseCase addItemUseCase)
        {
            _getItemsUseCase = getItemsUseCase;
            _addItemUseCase = addItemUseCase;
            AddItemCommand = new RelayCommand(AddItem);
        }

        /// <summary>
        /// Carga los elementos del almacén utilizando el caso de uso correspondiente.
        /// </summary>
        public async void LoadItems()
        {
            var items = await _getItemsUseCase.Execute();
            WarehouseItems.Clear();
            foreach (var item in items)
                WarehouseItems.Add(item);
        }

        /// <summary>
        /// Agrega un nuevo elemento al almacén y recarga la lista de elementos.
        /// </summary>
        private async void AddItem()
        {
            var newItem = new WarehouseItem { Name = "Nuevo Item", Quantity = 10 };
            await _addItemUseCase.Execute(newItem);
            LoadItems();
        }
    }
}