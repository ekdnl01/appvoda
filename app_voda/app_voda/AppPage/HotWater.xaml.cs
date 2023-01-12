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
    public partial class HotWater : ContentPage
    {
        public HotWater()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PokazaniaHW.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<PokazaniaHW>();

            var item = new PokazaniaHW()
            {
                Lschet = EntryLCH.Text,
                SchetchikNum = EntrySchetH.Text,
                PokazanieCW = EntryPokazanieH.Text
            };
            var lc = EntryLCH.Text;
            var sh = EntrySchetH.Text;
            var sc = EntryPokazanieH.Text;
            var dat = DateTime.Today;

            if (dat.Day < 11 || dat.Day > 25)
            {

                DisplayAlert("Ошибка", "Прием показаний ведется с 11 по 25 число каждого месяца", "", "Ок");
            }

            else if (String.IsNullOrEmpty(EntryLCH.Text))
            {
                DisplayAlert("Ошибка", "Лицевой счет не указан", "", "Ок");

            }
            else if (String.IsNullOrEmpty(EntrySchetH.Text))
            {
                DisplayAlert("Ошибка", "Номер счетчика не указан", "", "Ок");

            }
            else if (String.IsNullOrEmpty(EntryPokazanieH.Text))
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