

namespace MauiApp3;

public partial class LoginPopup : ContentView
{
	public LoginPopup()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

        Application.Current.MainPage = new MainMenuPage();
    }
}