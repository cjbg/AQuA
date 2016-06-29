using System.Collections.Generic;
using System.IO;
using QuizManager.Model;
using QuizManager.Model.Interface;
using QuizManager.View.Interface;

namespace QuizManager.Presenter
{
  public class MenuPresenter
  {
    private const string Name = "Name";
    private const string Value = "Value";
    private readonly IMenuView _view;
    private readonly IMenuModel _model;

    public MenuPresenter(IMenuView view)
    {
      _view = view;
      _model = new MenuModel();

      //SetQuizComboBox();
    }

    //TODO: Populate checkbox
    //private void SetQuizComboBox()
    //{
    //  List<QuizSet> quizSets = new List<QuizSet>();
    //  quizSets.Add(new QuizSet { Name = "Z pliku", Value = "FromFile" });
    //  quizSets.Add(new QuizSet { Name = "Pytania 1-114", Value = "Questions_1_114" });
    //  quizSets.Add(new QuizSet { Name = "Questions_115_294", Value = "Questions_115_294" });
    //  quizSets.Add(new QuizSet { Name = "Pytania W1W2W3W4", Value = "Questions_W1W2W3W4" });
    //  quizSets.Add(new QuizSet { Name = "Pytania ze zdjęć", Value = "QuestionsFromPictures" });

    //  _view.QuizComboBox.DataSource = quizSets;
    //  _view.QuizComboBox.DisplayMember = Name;
    //  _view.QuizComboBox.ValueMember = Value;
    //}
  }
}
