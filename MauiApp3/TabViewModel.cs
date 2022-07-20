namespace MauiApp3;

public class TabViewModel : ObservableObject
{
    private string _title;
    private string _content;
    private bool _isSelected;

    public TabViewModel()
    {
     
    }
    public TabViewModel(string title)
    {
        this.Title = title;
        this.Content = title;
    }

    public string Title { get { return _title; } set { _title = value; OnPropertyChanged(nameof(Title)); } }


    public string Content
    {
        get { return _content; }
        set { _content = value; OnPropertyChanged(nameof(Content)); }
    }

    public bool IsSelected
    {
        get { return _isSelected; }
        set { _isSelected = value; OnPropertyChanged(nameof(IsSelected)); }
    }
}