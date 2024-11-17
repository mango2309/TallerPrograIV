namespace TallerPrograIV;

public partial class AbsoluteLayoutPage : ContentPage
{
	public AbsoluteLayoutPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {

    }
}