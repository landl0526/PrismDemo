﻿using System;
using System.Collections.Generic;
using System.Text;
using Prism.Commands;
using Prism.Navigation;

namespace PrismDemo2.ViewModels
{
    public class MyMasterDetailViewModel : ViewModelBase
    {
        INavigationService _navigationService;

        public DelegateCommand<string> NavigateCommand { get; set; }
        public MyMasterDetailViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }
        private async void Navigate(string name)
        {
            var result = await _navigationService.NavigateAsync(name);
            if (!result.Success)
            {

            }
        }
    }
}
