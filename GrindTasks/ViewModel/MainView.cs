using System.Collections.ObjectModel;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SQLite;
using GrindTasks.ViewModel;

namespace GrindTasks.ViewModel
{
    public partial class MainView : ObservableObject
    {

        [RelayCommand]

        Task Navigate() => Shell.Current.GoToAsync("CreatedTasks");

    }


}

