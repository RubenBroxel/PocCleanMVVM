// GetPurchaseOrdersUseCase.cs (AppCore Layer)
using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace AppCore.Purchase
{
    public class GetPurchaseOrdersUseCase
    {
        private readonly IPurchaseRepository _repository;
        public GetPurchaseOrdersUseCase(IPurchaseRepository repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<PurchaseOrder>> Execute() => await _repository.GetAllAsync();
    }
}