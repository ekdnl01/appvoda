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
    public partial class admin : ContentPage
    {
        public admin()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            infosList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }
        // обработка нажатия элемента в списке
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            InfoList selectedInfo = (InfoList)e.SelectedItem;
            PageInfo infoPage = new PageInfo();
            infoPage.BindingContext = selectedInfo;
            await Navigation.PushAsync(infoPage);
        }
        // обработка нажатия кнопки добавления
        private async void CreateInfo(object sender, EventArgs e)
        {
            InfoList info = new InfoList();
            PageInfo infoPage = new PageInfo();
            infoPage.BindingContext = info;
            await Navigation.PushAsync(infoPage);
        }
    }
}