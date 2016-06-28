using System.Collections.Generic;

namespace QuizManager.Model.Interface
{
  public interface IQuizModel
  {
    bool ShuffleAnswers { get; set; }

    bool HideAnswerLetter { get; set; }

    List<Question> Questions { get; set; }

    bool IsAllAnswered();    
  }
}
