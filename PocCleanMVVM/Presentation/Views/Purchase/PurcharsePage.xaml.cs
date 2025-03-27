// PurchasePage.xaml.cs
using PocCleanMVVM.Presentation.ViewModels;

namespace PocCleanMVVM.Presentation.Views
{
    /// <summary>
    /// Code-behind para la vista de la página de compras.
    /// Se utiliza para inicializar la vista y establecer el contexto de enlace de datos.
    /// </summary>
    public partial class PurchasePage : ContentPage
    {
        /// <summary>
        /// Constructor de la clase PurchasePage.
        /// Inicializa los componentes de la vista y establece el BindingContext.
        /// </summary>
        /// <param name="viewModel">El ViewModel asociado a la vista de compras.</param>
        public PurchasePage(PurchaseViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}