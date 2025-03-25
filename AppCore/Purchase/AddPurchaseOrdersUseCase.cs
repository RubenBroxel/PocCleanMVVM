using Domain.Entities;
using Domain.Interfaces;

namespace AppCore.Purchase
{
    public class AddPurchaseOrderUseCase
    {
        private readonly IPurchaseRepository _repository;
        public AddPurchaseOrderUseCase(IPurchaseRepository repository)
        {
            _repository = repository;
        }
        public async Task Execute(PurchaseOrder order) => await _repository.AddAsync(order);
    }
}