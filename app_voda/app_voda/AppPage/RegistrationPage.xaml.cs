using app_voda.Tables;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app_voda.AppPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            

            var database = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(database);
            db.CreateTable<UserRegistration>();

            var item = new UserRegistration()
            {
                Username = EntryUserName.Text,
                Password = EntryUserPassword.Text,
                Email = EntryUserEmail.Text,
                Street = EntryUserStreet.Text,
                HouseNumber = EntryHouseNumber.Text
            };


            var email = EntryUserEmail.Text;

            var emailPattern = "^(?(\")(\".+?(?<!\\\\)\"@)|(([0-9a-z]((\\.(?!\\.))|[-!#\\$%&'\\*\\+/=\\?\\^`\\{\\}\\|~\\w])*)(?<=[0-9a-z])@))(?(\\[)(\\[(\\d{1,3}\\.){3}\\d{1,3}\\])|(([0-9a-z][-\\w]*[0-9a-z]*\\.)+[a-z0-9][\\-a-z0-9]{0,22}[a-z0-9]))$";

            if (item != null)
            {
                db.Insert(item);
                App.Current.MainPage = new NavigationPage(new LoginPage());


                //    Device.BeginInvokeOnMainThread(async () =>
                //   {
                //     var result = await this.DisplayAlert("Оповещение", "Регистрация прошла успешно", "", "Ок");

                //        if (result)
                //       await Navigation.PushAsync(new LoginPage());

                // });

            }

            if (String.IsNullOrEmpty(EntryUserEmail.Text))
            {
                DisplayAlert("Ошибка", "Необходимо заполнить все поля", "", "Ок");
                App.Current.MainPage = new NavigationPage(new RegistrationPage());
            }
            

            else if (String.IsNullOrEmpty(EntryUserName.Text))
            {
                DisplayAlert("Ошибка", "Необходимо заполнить все поля", "", "Ок");
                App.Current.MainPage = new NavigationPage(new RegistrationPage());
            }

            else if (String.IsNullOrEmpty(EntryUserPassword.Text))
            {
                DisplayAlert("Ошибка", "Необходимо заполнить все поля", "", "Ок");
                App.Current.MainPage = new NavigationPage(new RegistrationPage());
            }

            else if (String.IsNullOrEmpty(EntryUserStreet.Text))
            {
                DisplayAlert("Ошибка", "Необходимо заполнить все поля", "", "Ок");
                App.Current.MainPage = new NavigationPage(new RegistrationPage());
            }

            else if (String.IsNullOrEmpty(EntryHouseNumber.Text))
            {
                DisplayAlert("Ошибка", "Необходимо заполнить все поля", "", "Ок");
                App.Current.MainPage = new NavigationPage(new RegistrationPage());
            }

            else if (Regex.IsMatch(email, emailPattern))
                {
                    ErrorLabel.Text = "";
                }
                else
                {
                    DisplayAlert("Ошибка", "Введен неправильный email", "", "Ок");
                    App.Current.MainPage = new NavigationPage(new RegistrationPage());
                }




        }
    }
} 
