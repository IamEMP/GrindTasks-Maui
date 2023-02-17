using System;
using System.Windows.Input;
using GrindTasks.View;
using XCalendar.Core.Extensions;
using XCalendar.Core.Models;

namespace GrindTasks.ViewModel
{
	internal class CalendarViewModel
    {
        public Calendar<CalendarDay> MyCalendar { get; set; } = new Calendar<CalendarDay>();

        public ICommand NavigateCalendarCommand { get; set; }
        public CalendarViewModel()
        {
            NavigateCalendarCommand = new Command<int>(NavigateCalendar);
        }
        public void NavigateCalendar(int amount)
        {
            
            DateTime targetDateTime = MyCalendar.NavigatedDate.AddMonths(amount);

            MyCalendar.Navigate(targetDateTime - MyCalendar.NavigatedDate);

        }
    }
}

