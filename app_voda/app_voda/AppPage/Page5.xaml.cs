using Plugin.Messaging;
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
    public partial class Page5 : ContentPage
    {
        public Page5()
        {
            Title = "Контакты";
            InitializeComponent();
        }

        [Obsolete]
        async void Button_Clicked(object sender, EventArgs e)
        {

            // Device.OpenUri(new Uri("https://yandex.ru/maps/org/primorskiy_vodokanal/1004287745/?ll=131.913180%2C43.132855&z=18"));
            await Navigation.PushAsync(new MapPage());
        }

        [Obsolete]
        private void open_vk (object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://vk.com/primvoda"));
        }

        [Obsolete]
        private void open_ig(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.instagram.com/primvoda/"));
        }

        private void make_call(object sender, EventArgs e)
        {
            var phonecall = CrossMessaging.Current.PhoneDialer;
            if (phonecall.CanMakePhoneCall)
            {
                phonecall.MakePhoneCall("8 (423) 200-5-777", "Приморский Водоканал");
            }
        }

        private void send_email(object sender, EventArgs e)
        {
            var emailmes = CrossMessaging.Current.EmailMessenger;
            if (emailmes.CanSendEmail)
            {
                emailmes.SendEmail("prim@primvoda.ru", "", "");

            }
        }

        [Obsolete]
        private void open_tw(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://twitter.com/primvoda"));
        }

        [Obsolete]
        private void open_fc(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://ru-ru.facebook.com/primvoda"));
        }
    }
}