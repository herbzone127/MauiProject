namespace MauiApp3;

public partial class MainMenuPage : ContentPage
{

    public MainMenuPage()
	{
		InitializeComponent();
        this.BindingContext = new MainViewModel();

    }

    private void CarouselView_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
    {
        if (e.CurrentItem != null)
        {
            CustomTabsView.ScrollTo(e.CurrentItem, null, ScrollToPosition.Center, true);
        }
     
    }

}

