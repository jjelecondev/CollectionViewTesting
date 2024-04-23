using CollectionViewTesting.ViewModels;
using Sharpnado.CollectionView;


namespace CollectionViewTesting.Views.Components
{
    class FeedDataTemplateSelector :DataTemplateSelector
    {
        public SizedDataTemplate AnnouncementTemplate { get; set; }
        public SizedDataTemplate ApprovalTemplate { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            switch (item)
            {
                case AnnouncementVM announcementVM:
                    return AnnouncementTemplate;
                case ApprovalVM approvalVM:
                    return ApprovalTemplate;
                default:
                    return null;
            }
        }
    }
}
