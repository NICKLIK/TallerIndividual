namespace TallerIndividual;

public partial class FlexLayout : ContentPage
{
	public FlexLayout()
	{
		InitializeComponent();
	}

    private void OnImageTapped(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AbsoluteLayout());
    }
}