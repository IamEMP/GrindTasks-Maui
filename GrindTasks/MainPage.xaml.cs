using System.Collections.ObjectModel;
using GrindTasks.ViewModel;


namespace GrindTasks;

public partial class MainPage : ContentPage
{

	public MainPage(MainView vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}


