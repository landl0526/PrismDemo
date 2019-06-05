using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using PrismDemo2.ViewModels;
using PrismDemo2.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrismDemo2
{
    public partial class App : PrismApplication
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync($"MyMasterDetail/GradientHeaderNavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MyMasterDetail>();
            containerRegistry.RegisterForNavigation<GradientHeaderNavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
        }
    }
}
