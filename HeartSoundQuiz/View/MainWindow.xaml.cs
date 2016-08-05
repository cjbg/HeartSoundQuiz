using System.Windows;
using HeartSoundQuiz.Model;
using HeartSoundQuiz.View.Interfaces;
using HeartSoundQuiz.ViewModel;
using Microsoft.Win32;

namespace HeartSoundQuiz
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window, IMenuView
  {
    private MenuViewModel _menuViewModel;

    public MainWindow()
    {
      InitializeComponent();
    }

    private void Grid_Initialized(object sender, System.EventArgs e)
    {
      _menuViewModel = new MenuViewModel(this, new MenuModel());
    }

    private void ButtonAddSound_Click(object sender, RoutedEventArgs e)
    {
      _menuViewModel.AddSound();
    }
  }
}
