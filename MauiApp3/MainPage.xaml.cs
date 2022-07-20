namespace MauiApp3;

public partial class MainPage : ContentPage
{
    //int count = 0;
    double x, y;
    public MainPage()
	{
		InitializeComponent();
        popupView.Content = new LoginPopup();
        //popupView.Panning += (dd, ee) =>
        //{
        //    if (ee.Touches != null)
        //    {
        //        if (ee.Touches.Length == 1)
        //        {
        //            //draggableView.TranslationX = ee.Touches[0].X;
        //            //draggableView.TranslationY = ee.Touches[0].Y;
        //            draggableView.TranslationX += ee.DeltaDistance.X;
        //            draggableView.TranslationY += ee.DeltaDistance.Y;
        //        }
        //    }
        //};
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		//count++;

		//if (count == 1)
		//	CounterBtn.Text = $"Clicked {count} time";
		//else
		//	CounterBtn.Text = $"Clicked {count} times";

		//SemanticScreenReader.Announce(CounterBtn.Text);
	}

    private void PanGestureRecognizer_PanUpdated(object sender, PanUpdatedEventArgs e)
    {
        switch (e.StatusType)
        {
            case GestureStatus.Running:
                // Translate and ensure we don't pan beyond the wrapped user interface element bounds.
                popupView.TranslationX =
                  Math.Max(Math.Min(0, x + e.TotalX), -Math.Abs(popupView.Width - App.Current.MainPage.Width));
                popupView.TranslationY =
                  Math.Max(Math.Min(0, y + e.TotalY), -Math.Abs(popupView.Height - App.Current.MainPage.Height));
                break;

            case GestureStatus.Completed:
                // Store the translation applied during the pan
                x = popupView.TranslationX;
                y = popupView.TranslationY;
                break;
        }
    }
}

