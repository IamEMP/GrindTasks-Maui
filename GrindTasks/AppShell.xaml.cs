namespace GrindTasks;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(ViewModel.CreatedTasks), typeof(ViewModel.CreatedTasks));
	}
}

