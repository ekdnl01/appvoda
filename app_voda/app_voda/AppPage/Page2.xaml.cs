using app_voda.Tables;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app_voda.AppPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDis.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<UserDiscon>();

            var item = new UserDiscon()
            {
                StreetDis = EntryDisStreet.Text,
                HouseDis = EntryDisHouse.Text,
                DateDis = EntryDisDate.Date,
                CommentDis = EntryDisComment.Text
            };

            string disconst = EntryDisStreet.Text;
            string disconhs = EntryDisHouse.Text;


            if (String.IsNullOrEmpty(disconst))
            {
                DisplayAlert("Ошибка", "Улица не указана", "", "Ок");
               
            }
            else if (String.IsNullOrEmpty(disconhs))
            {
                DisplayAlert("Ошибка", "Дом не указан", "", "Ок");
                
            }
            else if (disconst.Length < 5)
            {
                DisplayAlert("Ошибка", "Введен неверный формат улицы", "", "Ок");
            }

            else if (item != null)
            {
                db.Insert(item);
                DisplayAlert("Оповещение", "Информация отправлена", "", "Ок");
                EntryDisStreet.Text = null;
                EntryDisHouse.Text = null;
                EntryDisComment.Text = null;
                
            }

            


        }
    }
}