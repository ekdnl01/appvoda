using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app_voda.AppPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Schet : ContentPage
    {
        public Schet()
        {
            InitializeComponent();
        }

        async private void Open_cw(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HotWater());
        }

        async private void Open_hw(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ColdWater());
        }
    }
}