using app_voda.Tables;
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
    public partial class PageInfo : ContentPage
    {
        public PageInfo()
        {
            InitializeComponent();
        }

        private void SaveInfo(object sender, EventArgs e)
        {
            var info = (InfoList)BindingContext;
            if (!String.IsNullOrEmpty(info.Street))
            {
                App.Database.SaveItem(info);
            }
            this.Navigation.PopAsync();
        }
        private void DeleteInfo(object sender, EventArgs e)
        {
            var info = (InfoList)BindingContext;
            App.Database.DeleteItem(info.Number);
            this.Navigation.PopAsync();
        }
        private void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}