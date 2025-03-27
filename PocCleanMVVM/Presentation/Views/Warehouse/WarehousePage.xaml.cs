// WarehousePage.xaml.cs
using PocCleanMVVM.Presentation.ViewModels;

namespace PocCleanMVVM.Presentation.Views
{
    /// <summary>
    /// Code-behind para la vista de la página del almacén.
    /// Se utiliza para inicializar la vista y establecer el contexto de enlace de datos.
    /// </summary>
    public partial class WarehousePage : ContentPage
    {
        /// <summary>
        /// Constructor de la clase WarehousePage.
        /// Inicializa los componentes de la vista y establece el BindingContext.
        /// </summary>
        /// <param name="viewModel">El ViewModel asociado a la vista del almacén.</param>
        public WarehousePage(WarehouseViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}