// WarehouseRepository.cs (Infrastructure Layer)
using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Infrastructure.Persistence
{
    public class WarehouseRepository : IWarehouseRepository
    {
        private readonly List<WarehouseItem> _items = new();
        public async Task<IEnumerable<WarehouseItem>> GetAllAsync() => await Task.FromResult(_items);
        public async Task AddAsync(WarehouseItem item)
        {
            _items.Add(item);
            await Task.CompletedTask;
        }
    }
}