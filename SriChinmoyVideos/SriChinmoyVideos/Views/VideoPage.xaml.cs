using SriChinmoyVideos.ViewModels;
using System;

using Xamarin.Forms;

namespace SriChinmoyVideos.Views
{
    public partial class VideoPage : ContentPage
    {
        public VideoPage(object listing)
        {
            InitializeComponent();
            this.BindingContext = new VideoPageViewModel(listing);
        }

        public void OnBackButtonClicked(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}
