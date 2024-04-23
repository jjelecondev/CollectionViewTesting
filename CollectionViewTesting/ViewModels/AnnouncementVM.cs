

using CollectionViewTesting.Interfaces;

namespace CollectionViewTesting.ViewModels
{
    internal class AnnouncementVM : IFeedItem
    {
        public string Description { get; set; } = "";
        public ImageSource Avatar { get; set; }
        public Command AnnouncementTap { get; set; }
        public AnnouncementVM()
        {
            AnnouncementTap = new Command(OnTap);
            Description = "This is an announcement";
        }

        private void OnTap(object obj)
        {
        }
    }
}
