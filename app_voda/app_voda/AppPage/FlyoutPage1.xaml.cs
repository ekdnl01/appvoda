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
    public partial class FlyoutPage1 : FlyoutPage
    {
        List<MenuItems> MenuItems;
        public FlyoutPage1()
        {
            InitializeComponent();
            LabelName.Text = classStatic.nameuser;
            LabelStreet.Text = classStatic.streetuser;
            LabelHouse.Text = classStatic.numhouse;
            BindingContext = new RegistrationPage();
            NavigationPage.SetHasNavigationBar(this, false);
            MenuItems = new List<MenuItems>();
            MenuItems.Add(new MenuItems { OptionName = "Главная страница", Image= "home.png" });
            MenuItems.Add(new MenuItems { OptionName = "Подача информации об отключении", Image= "pen.png" });
            MenuItems.Add(new MenuItems { OptionName = "Карта отключений", Image= "map1.png" });
            MenuItems.Add(new MenuItems { OptionName = "Передать показания счетчиков", Image = "meter.png" });
            MenuItems.Add(new MenuItems { OptionName = "Новости", Image = "news.png" });
            MenuItems.Add(new MenuItems { OptionName = "Контакты", Image = "contact.png" });
            MenuItems.Add(new MenuItems { OptionName = "Настройки", Image = "setting.png" });
            MenuItems.Add(new MenuItems { OptionName = "Выйти", Image = "logout.png" });

            if (classStatic.nameuser == "admin" && classStatic.password == "admin")
            {
                MenuItems.Add(new MenuItems { OptionName = "Админ", Image = "logout.png" });
            }

            navigationList.ItemsSource = MenuItems;
            Detail = new NavigationPage(new Page1());
        }

        private void navigationList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            try
            {
                var item = e.Item as MenuItems;

                switch (item.OptionName)
                {
                    case "Главная страница":
                        {
                            Detail = new NavigationPage(new Page1());
                            IsPresented = false;
                        }
                        break;
                    case "Подача информации об отключении":
                        {
                            Detail = new NavigationPage(new Page2());
                            IsPresented = false;
                        }
                        break;
                    case "Карта отключений":
                        {
                            Detail = new NavigationPage(new Page3());
                            IsPresented = false;
                        }
                        break;
                    case "Передать показания счетчиков":
                        {
                            Detail = new NavigationPage(new Schet());
                            IsPresented = false;
                        }
                        break;
                    case "Новости":
                        {
                            Detail = new NavigationPage(new Page4());
                            IsPresented = false;
                        }
                        break;
                    case "Контакты":
                        {
                            Detail = new NavigationPage(new Page5());
                            IsPresented = false;
                        }
                        break;
                    case "Настройки":
                        {
                            Detail = new NavigationPage(new Page6());
                            IsPresented = false;
                        }
                        break;
                    case "Выйти":
                        {
                            Navigation.PushAsync(new LoginPage());
                            IsPresented = false;
                        }
                        break;
                    case "Админ":
                        {
                            Navigation.PushAsync(new admin());
                            IsPresented = false;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {

            }
        }


    }
    public class MenuItems
    {
        public string OptionName { get; set; }
        public string Image { get; set; }
    }
}