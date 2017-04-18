using SriChinmoyVideos.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SriChinmoyVideos.ViewModels
{
    public class MainPageViewModel
    {
        #region Properties

        public string PageTitle
        {
            get { return "Sri Chinmoy Videos"; }
        }

        public ObservableCollection<Listing> Listings { get; private set; }

        #endregion

        public MainPageViewModel()
        {
            this.InitializeListings();
        }

        private void InitializeListings()
        {
            this.Listings = new ObservableCollection<Listing>();

            this.Listings.Add(new Listing
            {
                Name = "Prayer",
                Image = "CKG1.png",
                UrlAddress = "https://yuvid.com/cloud/video.php?id=56797507-6166-44BB-9A91-0B3C1F6FF355&amp;type=hd",
            });

            this.Listings.Add(new Listing
            {
                Name = "Chanting",
                Image = "CKG2.png",
                UrlAddress = "https://yuvid.com/cloud/video.php?id=FFBC9ACB-08D9-4EE8-B6EA-1B2B8766A497&amp;type=hd",
            });

            this.Listings.Add(new Listing
            {
                Name = "Singing",
                Image = "CKG3.png",
                UrlAddress = "https://yuvid.com/cloud/video.php?id=1084687C-F10F-4AC3-A339-758226196E07&amp;type=hd",
            });

            this.Listings.Add(new Listing
            {
                Name = "Music",
                Image = "CKG4.png",
                UrlAddress = "https://yuvid.com/cloud/video.php?id=8F442425-00CA-428F-8009-4AB92416910E&amp;type=hd",
            });
            this.Listings.Add(new Listing
            {
                Name = "Concentration",
                Image = "CKG5.png",
                UrlAddress = "https://yuvid.com/cloud/video.php?id=E6FC0772-F752-4717-AA96-073ADD51BB7D&amp;type=hd",
            });
            this.Listings.Add(new Listing
            {
                Name = "Meditation",
                Image = "CKG6.png",
                UrlAddress = "https://yuvid.com/cloud/video.php?id=8F442425-00CA-428F-8009-4AB92416910E&amp;type=hd",
            });
            this.Listings.Add(new Listing
            {
                Name = "Contemplation",
                Image = "CKG7.png",
                UrlAddress = "https://yuvid.com/cloud/video.php?id=B0A65767-A2E6-4424-BA9A-1FC485E69382&amp;type=hd",
            });
            this.Listings.Add(new Listing
            {
                Name = "Samadhi",
                Image = "CKG8.png",
                UrlAddress = "https://yuvid.com/cloud/video.php?id=2D9D461A-8598-4D20-966D-BEC679DC6FF6&amp;type=hd",
            });
        }
    }
}
