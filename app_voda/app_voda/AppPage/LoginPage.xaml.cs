using app_voda.Tables;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app_voda.AppPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationPage());
        }

        async void Button_Clicked_1(object sender, EventArgs e)
        {

            var database = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(database);
            var reg = db.Table<UserRegistration>().Where(item => item.Email.Equals(EntryEmail.Text) && item.Password.Equals(EntryPassword.Text)).FirstOrDefault();

            //await DisplayAlert("ol", $"{classStatic.nameuser}", "1", "1");
            if (reg != null)
            {
                classStatic.nameuser = reg.Username;
                classStatic.numhouse = reg.HouseNumber;
                classStatic.streetuser = reg.Street;
                classStatic.password = reg.Password;
                App.Current.MainPage = new NavigationPage(new FlyoutPage1());
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await DisplayAlert("Ошибка", "Введен неправильный Email или пароль", "", "Ок");
                    await Navigation.PushAsync(new LoginPage());

                });
            }

        }
        
    }
}