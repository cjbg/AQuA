using System.Drawing;

namespace QuizManager.View.Interface
{
  public interface IQuizView
  {
    string Question { get; set; }

    string Answer1 { get; set; }

    string Answer2 { get; set; }

    string Answer3 { get; set; }

    string Answer4 { get; set; }

    string Answer5 { get; set; }

    string ColorAnswer1 { set; }

    string ColorAnswer2 { set; }

    string ColorAnswer3 { set; }

    string ColorAnswer4 { set; }

    string ColorAnswer5 { set; }

    bool CheckedAnswer1 { get; set; }

    bool CheckedAnswer2 { get; set; }

    bool CheckedAnswer3 { get; set; }

    bool CheckedAnswer4 { get; set; }

    bool CheckedAnswer5 { get; set; }

    bool CheckButtonEnabled { get; set; }

    bool LearnedButtonEnabled { get; set; }

    bool NextButtonEnabled { get; set; }

    int HeightAnswer1 { set; }

    bool VisibleAnswer1 { set; }

    bool VisibleAnswer2 { set; }

    bool VisibleAnswer3 { set; }

    bool VisibleAnswer4 { set; }

    bool VisibleAnswer5 { set; }
  }
}