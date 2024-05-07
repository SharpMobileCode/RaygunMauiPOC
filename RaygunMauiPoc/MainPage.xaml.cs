namespace RaygunMauiPoc;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

		BindingContext = new MainViewModel();
	}

    public void CounterBtn_Clicked(System.Object sender, System.EventArgs e)
    {
		CounterBtn.Text = "This is button text";
		throw new ArgumentNullException("counterButtonEventHandler", "Error thrown from button event handler");
    }
}


