using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Prism.Ioc;
using Prism;
using Xamarin.Forms;
using PrismDemo2.ViewModels;
using Android.Graphics.Drawables;
using Xamarin.Forms.Platform.Android;

namespace PrismDemo2.Droid
{
    [Activity(Label = "PrismDemo2", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App(new AndroidInitializer()));

            MessagingCenter.Subscribe<object, object>(this, "ChangeToolbar", (sender, args) =>
            {
                ToolbarColorManager model = args as ToolbarColorManager;

                var toolbar = MainActivity.RootFindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
                if (toolbar == null) return;

                toolbar.SetBackground(new GradientDrawable(GradientDrawable.Orientation.RightLeft,
                    new int[] { model.LeftColor.ToAndroid(), model.RightColor.ToAndroid() }));
            });
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        private static MainActivity instance;

        public static Android.Views.View RootFindViewById<T>(int id) where T : Android.Views.View
        {
            return instance.FindViewById<T>(id);
        }

        public MainActivity()
        {
            instance = this;
        }
    }

    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Register any platform specific implementations
        }
    }
}