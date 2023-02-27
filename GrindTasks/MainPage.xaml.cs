using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using GrindTasks.ViewModel;
using GrindTasks.Data;
using Microsoft.Maui.Controls;
using System.Text;
using SQLite;
using System.Threading.Tasks;



namespace GrindTasks;

public partial class MainPage : ContentPage
{

	public MainPage(MainView vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        collectionView.ItemsSource = await App.Database.GetTasksAsync();
    }



    async void OnButtonClicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(tasksEntry.Text))
        {
            await App.Database.SaveTasksAsync(new TaskData
            {
                taskDateList = taskDate.Date.ToShortDateString(),
                todolist = tasksEntry.Text

            }) ;

            tasksEntry.Text = string.Empty;


            collectionView.ItemsSource = await App.Database.GetTasksAsync();
        }


    }
        TaskData lastSelection;
        void collectionView_SelectionChanged(System.Object sender,
        SelectionChangedEventArgs e)
    {
        lastSelection = e.CurrentSelection[0] as TaskData;
        tasksEntry.Text = lastSelection.todolist;

    }

    //Update the Database
    async void Button_Clicked1(System.Object sender, System.EventArgs e)
    {
        if (lastSelection != null)
        {
            lastSelection.todolist = tasksEntry.Text;
            lastSelection.taskDateList = taskDate.Date.ToShortDateString();
            await App.Database.UpdateTasksAsync(lastSelection);
            collectionView.ItemsSource = await App.Database.GetTasksAsync();
        }
        tasksEntry.Text = "";
    }

    //Delete Entries
    async void Button_Clicked2(System.Object sender, System.EventArgs e)
    {
        if (lastSelection != null)
        {
            
            await App.Database.DeleteTasksAsync(lastSelection);
            collectionView.ItemsSource = await App.Database.GetTasksAsync();
        }
        tasksEntry.Text = "";
    }

    void taskDate_DateSelected(System.Object sender, Microsoft.Maui.Controls.DateChangedEventArgs e)
    {
        DatePicker.DateProperty.ToString();
        DatePicker datePicker = new DatePicker
        {
            MinimumDate = new DateTime(2023, 1, 1),
            MaximumDate = new DateTime(2085, 12, 31),
            
        };
    }

}


