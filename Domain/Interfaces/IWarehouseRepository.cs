// IWarehouseRepository.cs (Domain Layer)
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;
namespace Domain.Interfaces
{
    public interface IWarehouseRepository
    {
        Task<IEnumerable<WarehouseItem>> GetAllAsync();
        Task AddAsync(WarehouseItem item);
    }
}