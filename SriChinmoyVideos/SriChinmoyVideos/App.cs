using SriChinmoyVideos.Views;
using Xamarin.Forms;

namespace SriChinmoyVideos
{
    public class App : Application
    {
        public App()
        {
            var startPage = new MainPage();
            MainPage = new NavigationPage(startPage) { };
        }
    }
}
