using app_voda.AppPage;
using app_voda.Tables;
using System;
using System.IO;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
[assembly: ExportFont("NunitoSans-Regular.ttf", Alias = "ThemeFontRegular")]
[assembly: ExportFont("NunitoSans-SemiBold.ttf", Alias = "ThemeFontMedium")]
[assembly: ExportFont("NunitoSans-Bold.ttf", Alias = "ThemeFontBold")]
[assembly: ExportFont("Oswald-Bold.ttf", Alias = "OswaldBold")]
[assembly: ExportFont("Oswald-Regular.ttf", Alias = "OswaldRegular")]
[assembly: ExportFont("Philosopher-Bold.ttf", Alias = "PhilBold")]
[assembly: ExportFont("Philosopher-Regular.ttf", Alias = "PhilRegular")]
[assembly: ExportFont("Days.otf", Alias = "Days")]
[assembly: ExportFont("RobotoSlab-Bold.ttf", Alias = "RobBold")]
[assembly: ExportFont("RobotoSlab-Light.ttf", Alias = "RobLight")]
[assembly: ExportFont("RobotoSlab-Regular.ttf", Alias = "RobReg")]
[assembly: ExportFont("RobotoSlab-Thin.ttf", Alias = "RobThin")]
namespace app_voda
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "infos.db";
        public static InfoRepository database;
        public static InfoRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new InfoRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            Device.SetFlags(new[] { "Expander" });
            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
