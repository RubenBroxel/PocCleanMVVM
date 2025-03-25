// GetWarehouseItemsUseCase.cs (AppCore Layer)
using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace AppCore.Warehouse
{
    public class GetWarehouseItemsUseCase
    {
        private readonly IWarehouseRepository _repository;
        public GetWarehouseItemsUseCase(IWarehouseRepository repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<WarehouseItem>> Execute() => await _repository.GetAllAsync();
    }
}