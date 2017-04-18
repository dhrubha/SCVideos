using SriChinmoyVideos.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SriChinmoyVideos.ViewModels
{
    public class VideoPageViewModel
    {
        #region Properties

        public string PageTitle { get; private set; }
        public string Image { get; private set; }
        public string UrlAddress { get; set; }

        #endregion

        public VideoPageViewModel(object param)
        {
            var listing = param as Listing;

            this.PageTitle = listing.Name;
            this.Image = listing.Image;
            this.UrlAddress = listing.UrlAddress;

            Debug.WriteLine("listing.Name = " + listing.Name);
            Debug.WriteLine("listing.Image = " + listing.Image.ToString());

        }
    }
}
