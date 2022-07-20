using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MauiApp3;

public class MainViewModel : ObservableObject
{
    private TabViewModel _currentTabVm;
    int count = 1;

    public MainViewModel()
    {

        this.TabVms = new ObservableCollection<TabViewModel>();
        this.TabVms.Add(new TabViewModel("TAB" + count));
        TapCommand = new Command(OnTapped);
   
        this.CurrentTabVm = this.TabVms.FirstOrDefault();
    }


    void OnTapped(Object s)
    {
        count++;
        this.TabVms.Add(new TabViewModel("TAB" + count));
    }

    private ICommand _tapCommand;

    public ICommand TapCommand
    {
        get { return _tapCommand; }
        set { _tapCommand = value; }
    }


    public ObservableCollection<TabViewModel> TabVms { get; set; }

    public TabViewModel CurrentTabVm
    {
        get
        {
            return this._currentTabVm;
        }
        set
        {
            this._currentTabVm = value; 
            OnPropertyChanged(nameof(CurrentTabVm));
            //SetSelection();
        }
    }

    private void SetSelection()
    {
        
        //TabVms.ForEach(vm => vm.IsSelected = false);
        //CurrentTabVm.IsSelected = true;
    }
}