using CollectionViewTesting.ViewModels;

namespace CollectionViewTesting
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public MainPage()
        {
            InitializeComponent();
            MainPageVM vm = new MainPageVM();
            BindingContext = vm;
        }

    }

}
