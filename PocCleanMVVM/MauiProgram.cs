using AppCore.Purchase;
using AppCore.Sales;
using AppCore.Warehouse;
using Domain.Interfaces;
using Infrastructure.Persistence;
using Microsoft.Extensions.Logging;
using PocCleanMVVM.Presentation.ViewModels;
using PocCleanMVVM.Presentation.Views;

namespace PocCleanMVVM;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddSingleton<MainPage>();
        
		builder.Services.AddSingleton<IProductRepository, ProductRepository>();
        builder.Services.AddSingleton<ISaleRepository, SaleRepository>();
        builder.Services.AddSingleton<GetProductsUseCase>();
        builder.Services.AddSingleton<ProcessSaleUseCase>();
        builder.Services.AddTransient<SalesViewModel>();

            builder.Services.AddSingleton<IPurchaseRepository, PurchaseRepository>();
            builder.Services.AddSingleton<GetPurchaseOrdersUseCase>();
            builder.Services.AddSingleton<AddPurchaseOrderUseCase>();
            builder.Services.AddSingleton<PurchaseViewModel>();
            builder.Services.AddSingleton<PurchasePage>();
            

            builder.Services.AddSingleton<SalesViewModel>();
            builder.Services.AddSingleton<SalesPage>();
            
            builder.Services.AddSingleton<IWarehouseRepository, WarehouseRepository>();
            builder.Services.AddSingleton<GetWarehouseItemsUseCase>();
            builder.Services.AddSingleton<AddWarehouseItemUseCase>();
            builder.Services.AddSingleton<WarehouseViewModel>();
            builder.Services.AddSingleton<WarehousePage>();

            builder.Services.AddSingleton<GridPage>();
            
		return builder.Build();
	}
}
