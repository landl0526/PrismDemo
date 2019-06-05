using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using PrismDemo2.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ContentPage), typeof(CustomPageRenderer))]
namespace PrismDemo2.Droid
{
    public class CustomPageRenderer : PageRenderer
    {
        public CustomPageRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);

            var toolbar = MainActivity.RootFindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            if (toolbar == null) return;

            toolbar.SetBackground(new GradientDrawable(GradientDrawable.Orientation.RightLeft,
                new int[] { Color.Red.ToAndroid(), Color.Blue.ToAndroid() }));
        }
    }
}