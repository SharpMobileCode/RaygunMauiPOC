using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace RaygunMauiPoc;

public partial class MainViewModel : ObservableObject
{
	[ObservableProperty]
	[NotifyPropertyChangedFor(nameof(CountText))]
	private int count;

	public string CountText
	{
		get
		{
            string text;
            if (Count == 1)
			{
				text = $"Clicked {Count} time";
			}
			else
			{
				text = $"Clicked {Count} times";
			}

			return text;
		}
	}

	public MainViewModel()
	{
		count = 0;
	}

	[RelayCommand]
	private void UpdateCounter()
	{
		Count++;

		// Example of an unhandled exception. This exception does not appear in the Raygun
		// dashboard. I would expect this exception to appear in the dashboard as an unhandled
		// exception.
		throw new ArgumentNullException("someArgumentName", "someArgumentName can not be null.");
	}
}

