using QuizManager.Model;
using QuizManager.Model.Interface;
using QuizManager.View.Interface;

namespace QuizManager.Presenter
{
  public class MenuPresenter
  {
    private readonly IMenuView _view;
    private readonly IMenuModel _model;
    public MenuPresenter(IMenuView menuView)
    {
      _view = menuView;
      _model = new MenuModel();
    }

    public string ReadQuiz()
    {
      return Properties.Resources.Fizjologia_Pytania_1_114;
    }
  }
}