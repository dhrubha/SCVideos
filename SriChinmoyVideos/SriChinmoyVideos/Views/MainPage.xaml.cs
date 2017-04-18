using Xamarin.Forms;

namespace SriChinmoyVideos.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var listing = e.Item;
            if (listing == null)
                return;

            this.Navigation.PushAsync(new VideoPage(listing));
            this.ListingsListView.SelectedItem = null;
        }
    }
}
