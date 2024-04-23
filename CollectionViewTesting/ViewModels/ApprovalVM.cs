using CollectionViewTesting.Interfaces;
using System;
using System.Windows.Input;
namespace CollectionViewTesting.ViewModels
{
    internal class ApprovalVM : IFeedItem
    {
        public string UserName { get; set; }
        public string Description { get; set; }
        public string ListName {  get; set; }
        public string OrgName { get; set; }
        public bool IsUpdate { get; set; }
        public ImageSource Avatar { get; set; }
        public ICommand ApproveCommand { get;}
        public ApprovalVM()
        {
            ApproveCommand = new Command<Button>(i => OnApprove(i));
            UserName = "Bubba Ho-Tep";
            OrgName = "092384yhfw";
            ListName = "theList";
            Description = "Description";
            IsUpdate = false;
        }


        private void OnApprove(object obj)
        {
        }
    }
}

