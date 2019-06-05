using System;
using System.Collections.Generic;
using System.Text;
using Prism.Commands;
using Prism.Navigation;
using Xamarin.Forms;

namespace PrismDemo2.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public DelegateCommand ChangeToolbarCommand { set; get; }
        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            ChangeToolbarCommand = new DelegateCommand(() =>
            {
                var colorModel = new ToolbarColorManager { LeftColor = Color.FromHex("#92CD8C"), RightColor = Color.FromHex("#17AEC6") };
                MessagingCenter.Send<object, object>(this, "ChangeToolbar", colorModel);
            });
        }
    }

    public class ToolbarColorManager
    {
        public Color LeftColor { set; get; }

        public Color RightColor { set; get; }
    }
}
