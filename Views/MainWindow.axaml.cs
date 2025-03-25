using Avalonia.Controls;
using ListGo.ViewModels;
using SukiUI.Controls;

namespace ListGo.Views;

public partial class MainWindow : SukiWindow {
    public MainWindow() {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }
}