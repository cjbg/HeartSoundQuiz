using HeartSoundQuiz.Model.Interfaces;
using HeartSoundQuiz.View.Interfaces;
using Microsoft.Win32;

namespace HeartSoundQuiz.ViewModel
{
  public class MenuViewModel
  {
    private readonly IMenuView _view;
    private readonly IMenuModel _model;

    public MenuViewModel(IMenuView view, IMenuModel model)
    {      
      _view = view;
      _model = model;
    }

    public void AddSound()
    {
      OpenFileDialog fileDialog = new OpenFileDialog();
      fileDialog.Filter = ".mp3";
      fileDialog.ShowDialog();      
    }
  }
}
