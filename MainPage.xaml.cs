namespace TallerIndividual
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void GoToStackLayoutButtoned(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StackLayout());
        }

        private void GoToAbsoluteLayoutButton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AbsoluteLayout());
        }

        private void GoToGridLayoutButton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridLayout());
        }

        private void GoToFlexLayoutButton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FlexLayout());
        }

    }

}

