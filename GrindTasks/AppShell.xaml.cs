namespace GrindTasks;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(ViewModel.Calendar), typeof(ViewModel.Calendar));
	}
}

