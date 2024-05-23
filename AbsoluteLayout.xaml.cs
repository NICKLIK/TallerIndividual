namespace TallerIndividual;

public partial class AbsoluteLayout : ContentPage
{
	public AbsoluteLayout()
	{
		InitializeComponent();
	}

    private void GoToGridLayoutButton(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GridLayout());
    }
}