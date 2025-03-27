using Domain.Entities;
using Domain.Interfaces;

// Application Layer (Use Cases)
namespace AppCore.Sales
{   
    /// <summary>
    /// Caso de uso para procesar una venta.
    /// </summary>
    public class ProcessSaleUseCase
    {
        private readonly ISaleRepository _saleRepository;

        /// <summary>
        /// Constructor de la clase ProcessSaleUseCase.
        /// </summary>
        /// <param name="saleRepository">Repositorio de ventas.</param>
        public ProcessSaleUseCase(ISaleRepository saleRepository)
        {
            _saleRepository = saleRepository;
        }

        /// <summary>
        /// Ejecuta el caso de uso para procesar una venta.
        /// </summary>
        /// <param name="sale">La venta a procesar.</param>
        /// <returns>Un valor booleano indicando si la operación fue exitosa.</returns>
        public async Task<bool> ExecuteAsync(Sale sale)
        {
            return await _saleRepository.SaveSaleAsync(sale);
        }
    }
}