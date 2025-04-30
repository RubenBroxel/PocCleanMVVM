namespace PocCleanMVVM;

public partial class App : Application
{

	public App()
	{
		InitializeComponent();
		 MainPage = new MainPage();
	}

	protected override Window CreateWindow(IActivationState activationState)
	{
		Window window = base.CreateWindow(activationState);
		if (window == null)
    		throw new InvalidOperationException("Window cannot be null.");
		// Manipulate Window object
		return window;
		
	}
}
