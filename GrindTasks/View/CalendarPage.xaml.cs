using GrindTasks.ViewModel;

namespace GrindTasks.View;

public partial class CalendarPage : ContentPage
{
	public CalendarPage()
	{
		InitializeComponent();
		BindingContext = new CalendarViewModel();
	}
}
