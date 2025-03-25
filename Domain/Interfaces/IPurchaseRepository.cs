// IPurchaseRepository.cs (Domain Layer)
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;
namespace Domain.Interfaces
{
    public interface IPurchaseRepository
    {
        Task<IEnumerable<PurchaseOrder>> GetAllAsync();
        Task AddAsync(PurchaseOrder order);
    }
}