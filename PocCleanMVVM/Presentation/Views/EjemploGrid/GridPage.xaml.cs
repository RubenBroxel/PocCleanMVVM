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
                new ItemModel { Id = 1, Nombre = "Laptop", Categoria = "Electrónica", Precio = "$1000" },
                new ItemModel { Id = 2, Nombre = "Teléfono", Categoria = "Electrónica", Precio = "$500" },
                new ItemModel { Id = 3, Nombre = "Mouse", Categoria = "Accesorios", Precio = "$30" },
                new ItemModel { Id = 4, Nombre = "Teclado", Categoria = "Accesorios", Precio = "$50" }
            };

            BindingContext = this;
        }
    }

    public class ItemModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public string Precio { get; set; }
    }
}
