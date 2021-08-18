using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;


namespace Xamarin101JM.ViewModels
{
    public class CoffeeEquipmentViewModel : BaseViewModel
    {
        public CoffeeEquipmentViewModel()
        {
            IncreaseCount = new Command(OnIncrease);
            Title = "Coffee Equipment";
        }
        public ICommand IncreaseCount { get; set; }
        int count = 0;
        string countDisplay = "Push the button ;)";
        public string CountDisplay
        {
            get => countDisplay;
            set => SetProperty(ref countDisplay, value);
        }
        void OnIncrease()
        {
            count++;
            CountDisplay = $"You clicked {count} time(s)";
        }
    }
}
