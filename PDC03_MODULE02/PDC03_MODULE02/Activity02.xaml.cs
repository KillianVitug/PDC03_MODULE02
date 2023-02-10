using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MODULE02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Activity02 : ContentPage
    {
        public Activity02()
        {
            InitializeComponent();
        }

        void onSlideValueChanged(object sender,ValueChangedEventArgs args)
        {
            lblValue.Text=args.NewValue.ToString("F3");
        }
    }
}