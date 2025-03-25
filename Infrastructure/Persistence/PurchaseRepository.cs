// PurchaseRepository.cs (Infrastructure Layer)
using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Infrastructure.Persistence
{
    public class PurchaseRepository : IPurchaseRepository
    {
        private readonly List<PurchaseOrder> _orders = new();
        public async Task<IEnumerable<PurchaseOrder>> GetAllAsync() => await Task.FromResult(_orders);
        public async Task AddAsync(PurchaseOrder order)
        {
            _orders.Add(order);
            await Task.CompletedTask;
        }
    }
}