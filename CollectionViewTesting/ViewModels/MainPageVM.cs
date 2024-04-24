using CollectionViewTesting.Interfaces;
using PrayMore.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewTesting.ViewModels
{
    public class MainPageVM :BaseViewModel
    {
        private bool isRefreshing = false;
        public bool IsRefreshing
        {
            get
            {
                return isRefreshing;
            }
            set
            {
                SetProperty(ref isRefreshing, value);
            } 
        }
        private bool alreadyLoaded = false;
        public ObservableCollection<IFeedItem> FeedItems {get;set;} = new ObservableCollection<IFeedItem>();
        public Command RefreshFeedCommand { get; set; }
        public MainPageVM()
        {
            RefreshFeedCommand = new Command(DoRefresh);
            additems("-1");
        }
        public void additems(string add)
        {
            //adding items to feed
            AnnouncementVM announcementVM = new AnnouncementVM()
            {
                Description = "Don't refresh yet, go to page 2 first.  Load" + add,
            };
            ApprovalVM approvalVM = new ApprovalVM()
            {
                Description = "This is an approval"
            };
            FeedItems.Add(announcementVM);
            FeedItems.Add(approvalVM);
        }
        public void DoRefresh(object obj)
        {
            FeedItems.Clear();// => FeedItems = new ObservableCollection<IFeedItem>();
            additems("-2");
            IsRefreshing = false;
        }

    }
}
