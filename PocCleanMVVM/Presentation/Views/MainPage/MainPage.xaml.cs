using PocCleanMVVM.Presentation.Views;

namespace PocCleanMVVM
{
    /// <summary>
    /// Code-behind para la página principal de la aplicación.
    /// Proporciona navegación a diferentes vistas dentro de la aplicación.
    /// </summary>
    public partial class MainPage : ContentPage
    {
        private readonly IServiceProvider _serviceProvider;

        /// <summary>
        /// Constructor de la clase MainPage.
        /// Inicializa los componentes de la vista y configura el proveedor de servicios.
        /// </summary>
        /// <param name="serviceProvider">Proveedor de servicios para resolver dependencias.</param>
        public MainPage(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        /// <summary>
        /// Maneja el evento de clic para navegar a la página del almacén.
        /// </summary>
        private async void OnCounterClicked(object sender, EventArgs e)
        {
            var commentPage = _serviceProvider.GetRequiredService<WarehousePage>();
            await Navigation.PushAsync(commentPage);
        }

        /// <summary>
        /// Maneja el evento de clic para navegar a la página de compras.
        /// </summary>
        private async void OnCounterClicked2(object sender, EventArgs e)
        {
            var commentPage = _serviceProvider.GetRequiredService<PurchasePage>();
            await Navigation.PushAsync(commentPage);
        }

        /// <summary>
        /// Maneja el evento de clic para navegar a la página de ventas.
        /// </summary>
        private async void OnCounterClicked3(object sender, EventArgs e)
        {
            var commentPage = _serviceProvider.GetRequiredService<SalesPage>();
            await Navigation.PushAsync(commentPage);
        }

        /// <summary>
        /// Maneja el evento de clic para navegar a la página de cuadrícula.
        /// </summary>
        private async void OnCounterClicked4(object sender, EventArgs e)
        {
            var commentPage = _serviceProvider.GetRequiredService<GridPage>();
            await Navigation.PushAsync(commentPage);
        }

        /// <summary>
        /// Maneja el evento de clic para navegar a la página de cuadrícula.
        /// </summary>
        private async void OnCounterClicked5(object sender, EventArgs e)
        {
            var commentPage = _serviceProvider.GetRequiredService<GamePage>();
            await Navigation.PushAsync(commentPage);
        }


    }
}