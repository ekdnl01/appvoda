using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static app_voda.AppPage.Page4;

namespace app_voda
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(Property propertly)
        {
            InitializeComponent();
            this.Property = propertly;
            this.BindingContext = this;
        }

        public Property Property { get; set; }

        private void Back(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}