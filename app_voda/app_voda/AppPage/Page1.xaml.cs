using app_voda.Tables;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app_voda.AppPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {

        public Page1()
        {
            InitializeComponent();
            MEvents = GetEvents();
            this.BindingContext = this;

            LabelStreet1.Text = classStatic.streetuser; 
            LabelHouse1.Text = classStatic.numhouse;
            Title = "Главная страница";
            this.BindingContext = this;
            var database = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "infos.db");
            var db = new SQLiteConnection(database);
            var reg = db.Table<InfoList>().Where(InfoList => InfoList.Street.Equals(classStatic.streetuser) && InfoList.House.Equals(classStatic.numhouse)).FirstOrDefault();
            if (reg == null)
            {
                lb1.Text = "Отключений по адресу отсутствуют";
            }
                else
                {
                    lb1.Text = reg.Reason;
                    lb2.Text = reg.Date;
                }

        }
        public ObservableCollection<Event> MEvents { get; set; }
   
        private ObservableCollection<Event> GetEvents()
        {
            return new ObservableCollection<Event>
            {
               new Event {Title="Отключение водоснабжения", Reason="Плановые ремонтные работы",  Duration="02.06.2021 03:00 - 02.06.2021 - 23:45",  Description= "Адреса:" + Environment.NewLine + 
"Авраменко-2, 2-а, 2-б, 3, 5, 6, 8, 9, 9-а, 11, 13, 13-а, 15, 15-а, 16, 17, 17-а; Бестужева-5, 6а, 8; Верхнепортовая -9, 9-а, 11, 30, 32, 36, 38, 40, 40-а, 41, 41-в, 43, 44, 44-а, 45-а, 46, 47, 47-а, 49, 50-а, 51, 54, 56, 56-а, 58-а, 62-а, 62-б, 64, 68-в 64-а, 66, 68, 70, 72, 72/1, 72/2, 72/3, 76, 76-а, 76-б, 78, 78-а; Импортная; Казанская -1, 2, 4, 4/6, 5, 5-а, 7, 9; Керченская- 7, 7-а, 9, 9-а, 11.", Date= new DateTime(2021,6,2)},
               new Event {Title="Отключение водоснабжения", Reason="Плановые ремонтные работы",  Duration="03.06.2021 09:00 - 02.06.2021 - 18:00", Description="Адреса:" + Environment.NewLine +
"Дальзаводская - 1, 2, 4, 5, 13, 17, 21, 23, 25, 27, 27-а, 27-б, 27-в, 31; Металлистов- 17; Светланская 78- 106; Станюковича - 1, 3. 10, 12, 13, 13-а, 14, 15, 16, 29-а, 31-а, 37, 39, 44, 46, 48, 48б, 49, 49-а, 52, 53, 54, 54-б, 54-г, 55, 56, 57, 57-а, 57/1, 57/2, 58, 60, 60-а, 60-б, 62, 64, 66, 77-а; Стрельникова - 3, 3-а, 3-б, 4, 4/6, 5, 5-а, 6-а, 7, 8, 9, 9-а, 10, 10-а, 10-б, 12, 14; Токаревская кошка - 1, 3, 4, 46; Чернышевского.", Date = new DateTime(2021,6,3)},
               new Event {Title="Отключение водоснабжения", Reason="Плановые ремонтные работы",  Duration="08.06.2021 09:00 - 02.06.2021 - 18:00", Description="Адреса:" + Environment.NewLine + 
"Русская - 68/1, 68а, 68б, 70, 70а, 70б, 72, 72а, 72б, 72в, 74, 74а, 74б, 41а, 43.", Date = new DateTime(2021,6,8)}

            };
        }

        private Timer timer;

        public List<Banner> Banners { get => GetBanners(); }

        private List<Banner> GetBanners()
        {
            var bannerList = new List<Banner>();
            bannerList.Add(new Banner {  Message = "Отслеживайте аварии на карте", Image = "https://st2.depositphotos.com/1303735/8945/v/450/depositphotos_89457910-stock-illustration-abstract-city-map-with-red.jpg" });
            bannerList.Add(new Banner {  Message = "Подавайте информацию об отключении", Image = "https://im0-tub-ru.yandex.net/i?id=9dcf42cb25d2bfb54e55a0b34a48e5cd-l&ref=rim&n=13&w=1080&h=1080" });
            bannerList.Add(new Banner {  Message = "Подавайте показания счетчиков", Image = "https://avatars.mds.yandex.net/get-altay/248099/2a0000016049fc3f79f62936bc22270f064e/XXL" });
            return bannerList;
        }

        protected override void OnAppearing()
        {
            timer = new Timer(TimeSpan.FromSeconds(5).TotalMilliseconds) { AutoReset = true, Enabled = true };
            timer.Elapsed += Timer_Elapsed;
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            timer?.Dispose();
            base.OnDisappearing();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Device.BeginInvokeOnMainThread(() =>
            {

                if (cvBanners.Position == 2)
                {
                    cvBanners.Position = 0;
                    return;
                }

                cvBanners.Position += 1;
            });
        }

        private void Expander_Tapped(object sender, EventArgs e)
        {

        }
    }

    public class Event
    {
        public string Title { get; set; }
        public string Reason { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }

    public class Banner
    {
        public string Message { get; set; }
        public string Image { get; set; }
    }
}

