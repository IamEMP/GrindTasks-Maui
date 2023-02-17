namespace GrindTasks;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(View.CalendarPage), typeof(View.CalendarPage));
	}
}

