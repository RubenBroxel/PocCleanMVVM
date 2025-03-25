using Domain.Entities;
using Domain.Interfaces;
// Application Layer (Use Cases)
namespace AppCore.Sales
{   
    public class ProcessSaleUseCase
    {
        private readonly ISaleRepository _saleRepository;
        
        public ProcessSaleUseCase(ISaleRepository saleRepository)
        {
            _saleRepository = saleRepository;
        }
        
        public async Task<bool> ExecuteAsync(Sale sale)
        {
            return await _saleRepository.SaveSaleAsync(sale);
        }
    }
}