using System.Collections.ObjectModel;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GrindTasks.View;
using SQLite;
using GrindTasks.ViewModel;
using XCalendar.Core.Models;

namespace GrindTasks.ViewModel
{
    public partial class MainView : ObservableObject
    {

        [RelayCommand]
        static Task Navigate() => Shell.Current.GoToAsync("CalendarPage");

    }


}

