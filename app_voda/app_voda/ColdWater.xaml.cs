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

namespace app_voda
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ColdWater : ContentPage
    {
        public ColdWater()
        {
            InitializeComponent();
           
        }

         void Button_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PokazaniaCW.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<PokazaniaCW>();

            var item = new PokazaniaCW()
            {
                Lschet = EntryLC.Text,
                SchetchikNum = EntrySchet.Text,
                PokazanieCW = EntryPokazanie.Text
            };
            var lc = EntryLC.Text;
            var sh = EntrySchet.Text;
            var sc = EntryPokazanie.Text;
            var dat = DateTime.Today;

            if (dat.Day < 11 || dat.Day > 25)
            {

                DisplayAlert("Ошибка", "Прием показаний ведется с 11 по 25 число каждого месяца", "", "Ок");
            }

            else if (String.IsNullOrEmpty(EntryLC.Text))
            {
                DisplayAlert("Ошибка", "Лицевой счет не указан", "", "Ок");

            }
            else if (String.IsNullOrEmpty(EntrySchet.Text))
            {
                DisplayAlert("Ошибка", "Номер счетчика не указан", "", "Ок");

            }
            else if (String.IsNullOrEmpty(EntryPokazanie.Text))
            {
                DisplayAlert("Ошибка", "Показание не указано", "", "Ок");

            }
            else if (lc.Length < 9)
            {
                DisplayAlert("Ошибка", "Введен неверный формат лицевого счета", "", "Ок");
            }
            else if (sc.Length < 8)
            {
                DisplayAlert("Ошибка", "Показание введено неверно", "", "Ок");
            }
            else if (sh.Length < 4)
            {
                DisplayAlert("Ошибка", "Номер счетчика введен неверно", "", "Ок");
            }
            else if (item != null)
            {
                 db.Insert(item);
                 Navigation.PopAsync();
                 DisplayAlert("Оповещение", "Показания отправлены", "", "Ок");
            }
        }
    }
}