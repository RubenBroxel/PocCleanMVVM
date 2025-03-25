using System.Threading.Tasks;
using System.Windows.Input;
using Domain.Entities;
using PocCleanMVVM.Presentation.ViewModels;
using PocCleanMVVM.Presentation.Views;

namespace PocCleanMVVM;

public partial class MainPage : ContentPage
{
	private readonly IServiceProvider _serviceProvider;
	public MainPage(IServiceProvider serviceProvider)
	{
		InitializeComponent();
		_serviceProvider = serviceProvider;
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		var commentPage = _serviceProvider.GetRequiredService<WarehousePage>();
        await Navigation.PushAsync(commentPage);		
	}

		private async void OnCounterClicked2(object sender, EventArgs e)
	{
		var commentPage = _serviceProvider.GetRequiredService<PurchasePage>();
        await Navigation.PushAsync(commentPage);		
	}

	private async void OnCounterClicked3(object sender, EventArgs e)
	{
		var commentPage = _serviceProvider.GetRequiredService<SalesPage>();
        await Navigation.PushAsync(commentPage);		
	}
}
 