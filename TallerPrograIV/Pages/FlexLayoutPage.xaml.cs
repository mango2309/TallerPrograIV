namespace TallerPrograIV;

public partial class FlexLayoutPage : ContentPage
{
	public FlexLayoutPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new AbsoluteLayoutPage());
    }
}