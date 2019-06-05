using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrismDemo2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyMasterDetail : IMasterDetailPageOptions
    {
        public MyMasterDetail()
        {
            InitializeComponent();
        }

        public bool IsPresentedAfterNavigation => Device.Idiom != TargetIdiom.Phone;
    }
}