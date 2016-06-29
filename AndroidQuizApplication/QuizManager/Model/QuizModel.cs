using System;
using System.Collections.Generic;
using System.Linq;
using QuizManager.Model.Interface;

namespace QuizManager.Model
{
  public class QuizModel : IQuizModel
  {
    private const int DefaultRepetitionNumber = 1;
    private bool _shuffleAnswers;
    private bool _hideAnswerLetter;
    private int _repetitionNumber;
    private List<Question> _questions;

    public QuizModel(
      bool shuffleAnswers, 
      bool hideAnswerLetter,            
      List<Question> questions)
    {
      _shuffleAnswers = shuffleAnswers;
      _hideAnswerLetter = hideAnswerLetter;      
      _questions = questions;
    }

    public bool ShuffleAnswers
    {
      get { return _shuffleAnswers; }
      set { _shuffleAnswers = value; }
    }

    public bool HideAnswerLetter
    {
      get { return _hideAnswerLetter; }
      set { _hideAnswerLetter = value; }
    }

    public List<Question> Questions
    {
      get { return _questions; }
      set { _questions = value; }
    }

    public bool IsAllAnswered()
    {
      return Questions.All(x => x.RepetitionNumber <= 0);
    }

    public int ConvertRepetitionNumberText(string repetitionNumberText)
    {
      int repetitionNumber = DefaultRepetitionNumber;
      if (!string.IsNullOrWhiteSpace(repetitionNumberText))
      {
        repetitionNumber = Convert.ToInt32(repetitionNumberText);
      }

      return repetitionNumber;
    }
  }
}
