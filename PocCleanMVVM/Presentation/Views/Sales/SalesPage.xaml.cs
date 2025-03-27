// SalesPage.xaml.cs
using PocCleanMVVM.Presentation.ViewModels;

namespace PocCleanMVVM.Presentation.Views
{
    /// <summary>
    /// Code-behind para la vista de la página de ventas.
    /// Se utiliza para inicializar la vista y establecer el contexto de enlace de datos.
    /// </summary>
    public partial class SalesPage : ContentPage
    {
        /// <summary>
        /// Constructor de la clase SalesPage.
        /// Inicializa los componentes de la vista y establece el BindingContext.
        /// </summary>
        /// <param name="viewModel">El ViewModel asociado a la vista de ventas.</param>
        public SalesPage(SalesViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}