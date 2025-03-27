using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace PocCleanMVVM.Presentation.Views
{
    public partial class GridPage : ContentPage
    {
        public ObservableCollection<ItemModel> Items { get; set; }

        public GridPage()
        {
            InitializeComponent();

            Items = new ObservableCollection<ItemModel>
            {
                new ItemModel { Id = 1, Nombre = "Laptop",   Categoria = "Electrónica", Precio = "$1000.00" },
                new ItemModel { Id = 2, Nombre = "Teléfono", Categoria = "Electrónica", Precio = "$500.00"  },
                new ItemModel { Id = 3, Nombre = "Mouse",    Categoria = "Accesorios",  Precio = "$300.00"  },
                new ItemModel { Id = 4, Nombre = "Teclado",  Categoria = "Accesorios",  Precio = "$500.00"  }
            };

            BindingContext = this;
        }
    }

    public class ItemModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
        public string Precio { get; set; } = string.Empty;
    }
}
