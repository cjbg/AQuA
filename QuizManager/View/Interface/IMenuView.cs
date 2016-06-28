using System.Windows.Forms;

namespace QuizManager.View.Interface
{
  public interface IMenuView
  {
    bool ShuffleAnswers { get; }

    bool HideAnswerLetter { get; }

    string RepetitionNumberText { get; }    
  }
}
