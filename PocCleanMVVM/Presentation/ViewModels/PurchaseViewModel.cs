// PurchaseViewModel.cs (Presentation Layer)
using System.ComponentModel;
using System.Windows.Input;
using Domain.Entities;

namespace PocCleanMVVM.Presentation.ViewModels
{
    /// <summary>
    /// ViewModel para gestionar la lógica de la vista de compras.
    /// Implementa INotifyPropertyChanged para notificar cambios en las propiedades
    /// y IDisposable para liberar recursos si es necesario.
    /// </summary>
    public class PurchaseViewModel : INotifyPropertyChanged, IDisposable 
    {
        private string? _supplier;
        private decimal _totalAmount;
        private string? _message;

        /// <summary>
        /// Articulo asociado a la compra.
        /// </summary>
        public string? Supplier
        {
            get => _supplier;
            set
            {
                if (_supplier != value)
                {
                    _supplier = value ?? string.Empty;
                    OnPropertyChanged(nameof(Supplier));
                }
            }
        }

        /// <summary>
        /// Monto total de la compra.
        /// </summary>
        public decimal TotalAmount
        {
            get => _totalAmount;
            set
            {
                if (_totalAmount != value)
                {
                    _totalAmount = value;
                    OnPropertyChanged(nameof(TotalAmount));
                }
            }
        }

        /// <summary>
        /// Mensaje para mostrar información o errores relacionados con la compra.
        /// </summary>
        public string? Message
        {
            get => _message;
            set
            {
                if (_message != value)
                {
                    _message = value ?? string.Empty;
                    OnPropertyChanged(nameof(Message));
                }
            }
        }

        /// <summary>
        /// Comando para registrar una compra.
        /// </summary>
        public ICommand RegisterPurchaseCommand { get; }

        /// <summary>
        /// Constructor de la clase PurchaseViewModel.
        /// Inicializa el comando RegisterPurchaseCommand.
        /// </summary>
        public PurchaseViewModel()
        {
            RegisterPurchaseCommand = new Command(RegisterPurchase);
        }

        /// <summary>
        /// Lógica para registrar una compra.
        /// Valida los datos ingresados y genera un mensaje con los detalles de la compra.
        /// </summary>
        private void RegisterPurchase()
        {
            if (string.IsNullOrEmpty(Supplier))
            {
                Message = "Por favor, ingresa un Articulo.";
                return;
            }

            if (TotalAmount <= 0)
            {
                Message = "Por favor, ingresa un monto total válido.";
                return;
            }

            var purchaseOrder = new PurchaseOrder
            {
                Id = new Random().Next(1, 1000), // Simulando un ID aleatorio
                Supplier = Supplier,
                TotalAmount = TotalAmount
            };

            Message = $"Compra registrada:\nArticulo: {purchaseOrder.Supplier}\nMonto Total: {purchaseOrder.TotalAmount:C}";
        }

        /// <summary>
        /// Evento que se dispara cuando una propiedad cambia.
        /// Implementa INotifyPropertyChanged.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Método para notificar cambios en las propiedades.
        /// </summary>
        /// <param name="propertyName">Nombre de la propiedad que cambió.</param>
        protected virtual void OnPropertyChanged(string? propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Método para liberar recursos.
        /// Implementa IDisposable.
        /// </summary>
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}