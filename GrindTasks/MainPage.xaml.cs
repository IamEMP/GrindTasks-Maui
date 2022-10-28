namespace GrindTasks;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			newTaskButton.Text = $"Clicked {count} time";
		else
			newTaskButton.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(newTaskButton.Text);
	}
}


