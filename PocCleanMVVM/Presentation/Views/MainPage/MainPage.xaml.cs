using PocCleanMVVM.Presentation.Views;

namespace PocCleanMVVM
{
    /// <summary>
    /// Code-behind para la página principal de la aplicación.
    /// Proporciona navegación a diferentes vistas dentro de la aplicación.
    /// </summary>
    public partial class MainPage : ContentPage
    {
        /// <summary>
        /// Constructor de la clase MainPage.
        /// Inicializa los componentes de la vista y configura el proveedor de servicios.
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
            LoadPage(GetDashboardContent());
        }

        private void DashboardClicked(object sender, EventArgs e)
        {
           LoadPage(GetDashboardContent());
        }

        private void SettingsClicked(object sender, EventArgs e)
        {
            LoadPage(GetSettingsContent());
        }

        private void LoadPage(View content)
        {
            ContentArea.Content = content;
        }

        private View GetDashboardContent()
        {
            return new ScrollView
            {
                Content = new VerticalStackLayout
                {
                    Padding = 20,
                    Spacing = 10,
                    Children =
                    {
                        new Label { Text = "Dashboard", FontSize = 28, FontAttributes = FontAttributes.Bold, TextColor = Colors.Black },
                        new BoxView { HeightRequest = 1, Color = Colors.LightGray },
                        new Label { Text = "Bienvenido a tu panel principal.", FontSize = 16, TextColor = Colors.Gray }
                    }
                }
            };
        }    

        private View GetSettingsContent()
        {
            return new ScrollView
            {
                Content = new VerticalStackLayout
                {
                    Padding = 20,
                    Spacing = 10,
                    Children =
                    {
                        new Label { Text = "Settings", FontSize = 28, FontAttributes = FontAttributes.Bold, TextColor = Colors.Black },
                        new BoxView { HeightRequest = 1, Color = Colors.LightGray },
                        new Label { Text = "Aquí puedes configurar tu aplicación.", FontSize = 16, TextColor = Colors.Gray }
                    }
                }
            };
        }

    }
}