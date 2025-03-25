using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ListGo.ViewModels;

public partial class MainWindowViewModel : ObservableObject {
    public MainWindowViewModel() {
        Greeting = "Welcome to Avalonia!!!!";
    }
    
    [ObservableProperty]
    public partial string Greeting { get; set; }

    [RelayCommand]
    private void HelloAvalonia() {
        Debug.WriteLine("aaaCommand");
    }
}