using Maui.Domain.Contracts;

namespace Maui.ClientFactory
{
    public partial class MainPage : ContentPage
    {
        private readonly IMainPageViewModel _mainPageViewModel;

        public MainPage(IMainPageViewModel mainPageViewModel)
        {
            this._mainPageViewModel = mainPageViewModel;
            this.BindingContext = this._mainPageViewModel;
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {

        }
    }
}