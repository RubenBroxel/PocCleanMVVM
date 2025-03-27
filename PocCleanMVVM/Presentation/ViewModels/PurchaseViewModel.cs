// PurchaseViewModel.cs (Presentation Layer)
using System.ComponentModel;
using System.Windows.Input;
using Domain.Entities;

namespace PocCleanMVVM.Presentation.ViewModels
{
    public class PurchaseViewModel : INotifyPropertyChanged, IDisposable 
    {
        private string _supplier;
        private decimal _totalAmount;
        private string _message;

        public string Supplier
        {
            get => _supplier;
            set
            {
                if (_supplier != value)
                {
                    _supplier = value;
                    OnPropertyChanged(nameof(Supplier));
                }
            }
        }

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

        public string Message
        {
            get => _message;
            set
            {
                if (_message != value)
                {
                    _message = value;
                    OnPropertyChanged(nameof(Message));
                }
            }
        }

        public ICommand RegisterPurchaseCommand { get; }

        public PurchaseViewModel()
        {
            RegisterPurchaseCommand = new Command(RegisterPurchase);
        }

        private void RegisterPurchase()
        {
            if (string.IsNullOrEmpty(Supplier))
            {
                Message = "Por favor, ingresa un proveedor.";
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

            Message = $"Compra registrada:\nProveedor: {purchaseOrder.Supplier}\nMonto Total: {purchaseOrder.TotalAmount:C}";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
