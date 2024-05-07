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

		throw new ArgumentNullException("someArgumentName", "someArgumentName can not be null.");
	}
}

