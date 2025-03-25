// AddWarehouseItemUseCase.cs (AppCore Layer)
using Domain.Entities;
using Domain.Interfaces;

namespace AppCore.Warehouse
{
    public class AddWarehouseItemUseCase
    {
        private readonly IWarehouseRepository _repository;
        public AddWarehouseItemUseCase(IWarehouseRepository repository)
        {
            _repository = repository;
        }
        public async Task Execute(WarehouseItem item) => await _repository.AddAsync(item);
    }
}