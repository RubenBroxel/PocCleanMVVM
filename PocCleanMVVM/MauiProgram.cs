using AppCore.Purchase;
using AppCore.Sales;
using AppCore.Warehouse;
using Domain.Interfaces;
using Infrastructure.Persistence;
using Microsoft.Extensions.Logging;
using PocCleanMVVM.Presentation.ViewModels;
using PocCleanMVVM.Presentation.Views;

namespace PocCleanMVVM;

/// <summary>
/// Clase estática para configurar y construir la aplicación MAUI.
/// </summary>
public static class MauiProgram
{
    /// <summary>
    /// Configura y crea la aplicación MAUI.
    /// </summary>
    /// <returns>Una instancia de <see cref="MauiApp"/> configurada.</returns>
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                // Configuración de fuentes personalizadas.
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        // Registro de servicios y dependencias.

        // Página principal.
        builder.Services.AddSingleton<MainPage>();

        // Repositorios.
        builder.Services.AddSingleton<IProductRepository, ProductRepository>();
        builder.Services.AddSingleton<ISaleRepository, SaleRepository>();
        builder.Services.AddSingleton<IPurchaseRepository, PurchaseRepository>();
        builder.Services.AddSingleton<IWarehouseRepository, WarehouseRepository>();

        // Casos de uso.
        builder.Services.AddSingleton<GetProductsUseCase>();
        builder.Services.AddSingleton<ProcessSaleUseCase>();
        builder.Services.AddSingleton<GetPurchaseOrdersUseCase>();
        builder.Services.AddSingleton<AddPurchaseOrderUseCase>();
        builder.Services.AddSingleton<GetWarehouseItemsUseCase>();
        builder.Services.AddSingleton<AddWarehouseItemUseCase>();

        // ViewModels.
        builder.Services.AddSingleton<SalesViewModel>();
        builder.Services.AddSingleton<PurchaseViewModel>();
        builder.Services.AddSingleton<WarehouseViewModel>();

        // Vistas.
        builder.Services.AddSingleton<SalesPage>();
        builder.Services.AddSingleton<PurchasePage>();
        builder.Services.AddSingleton<WarehousePage>();
        builder.Services.AddSingleton<GridPage>();

        return builder.Build();
    }
}