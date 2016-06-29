using System;
using System.Collections.Generic;
using System.Linq;
using QuizManager.Model;
using QuizManager.Model.Interface;
using QuizManager.Service;
using QuizManager.Service.Interface;
using QuizManager.View.Interface;

namespace QuizManager.Presenter
{
  public class QuizPresenter
  {
    private const int DefaultRepetitionNumber = 1;
    private const int MaxHeight = 425;
    private const int DefaultHeight = 65;

    private readonly IQuizModel _model;
    private readonly IQuizView _view;
    private readonly IQuizReader _reader;

    private Question _currentQuestion;

    public QuizPresenter(
      bool shuffleAnswers,
      bool hideAnswerLetter,
      string repetitionNumberText,
      QuizSet quizSet,
      string filePath,
      IQuizView view)
    {
      _view = view;
      _reader = new QuizReader();

            
      //TODO: Refactor      
      int repetitionNumber = ConvertRepetitionNumber(repetitionNumberText);
      string textFromResource = _reader.GetQuizSetText(quizSet, filePath);
      List<Question> questions = _reader.ReadQuizFromResource(repetitionNumber, textFromResource);

      _model = new QuizModel(shuffleAnswers, hideAnswerLetter, questions);
      PrepareView();
    }

    private void PrepareView()
    {
      _currentQuestion = GetQuestion();
      SetViewData();
    }

    private void SetViewData()
    {
      _view.Question = _currentQuestion.Name;

      if (_currentQuestion.HasOneAnswer)
      {
        SetOneAnswer();
      }
      else
      {
        SetAnswerNames();
      }

      SetCheckedAnswers();
      SetAnswersColors();
    }

    public int ConvertRepetitionNumber(string repetitionNumberText)
    {
      int repetitionNumber = DefaultRepetitionNumber;
      if (!string.IsNullOrWhiteSpace(repetitionNumberText))
      {
        repetitionNumber = Convert.ToInt32(repetitionNumberText);
      }

      return repetitionNumber;
    }

    private void SetOneAnswer()
    {
      _view.Answer1 = SetAnswerName(_currentQuestion.Answers[0].Name);
      _view.Answer2 = string.Empty;
      _view.Answer3 = string.Empty;
      _view.Answer4 = string.Empty;
      _view.Answer5 = string.Empty;
      _view.VisibleAnswer1 = false;
      _view.VisibleAnswer2 = false;
      _view.VisibleAnswer3 = false;
      _view.VisibleAnswer4 = false;
      _view.VisibleAnswer5 = false;
      _view.HeightAnswer1 = MaxHeight;
    }

    private void SetAnswersColors()
    {
      //_view.ColorAnswer1 = Color.Black;
      //_view.ColorAnswer2 = Color.Black;
      //_view.ColorAnswer3 = Color.Black;
      //_view.ColorAnswer4 = Color.Black;
      //_view.ColorAnswer5 = Color.Black;
    }

    private void SetCheckedAnswers()
    {
      _view.CheckedAnswer1 = false;
      _view.CheckedAnswer2 = false;
      _view.CheckedAnswer3 = false;
      _view.CheckedAnswer4 = false;
      _view.CheckedAnswer5 = false;
    }

    private void SetAnswerNames()
    {
      _view.Answer1 = SetAnswerName(_currentQuestion.Answers[0].Name);
      _view.Answer2 = SetAnswerName(_currentQuestion.Answers[1].Name);
      _view.Answer3 = SetAnswerName(_currentQuestion.Answers[2].Name);
      _view.Answer4 = SetAnswerName(_currentQuestion.Answers[3].Name);
      _view.Answer5 = SetAnswerName(_currentQuestion.Answers[4].Name);
      _view.VisibleAnswer1 = true;
      _view.VisibleAnswer2 = true;
      _view.VisibleAnswer3 = true;
      _view.VisibleAnswer4 = true;
      _view.VisibleAnswer5 = true;
      _view.HeightAnswer1 = DefaultHeight;
    }

    private string SetAnswerName(string name)
    {
      if (_model.HideAnswerLetter)
      {
        return name.Substring(2, name.Length - 2);
      }

      return name;
    }

    private Question GetQuestion()
    {
      var question = GetRandom();

      if (_model.ShuffleAnswers && !question.HasOneAnswer)
      {
        question.Answers = ShuffleAnswers(question);
      }

      return question;
    }

    private Question GetRandom()
    {
      var random = new Random();
      Question question;
      do
      {
        var index = random.Next(_model.Questions.Count);
        question = _model.Questions[index];
      } while (question.RepetitionNumber == 0);
      return question;
    }

    private static List<Answer> ShuffleAnswers(Question question)
    {
      var random = new Random();
      return question.Answers.OrderBy(
          x => random.Next())
        .ToList();
    }

    public void CheckAnswers()
    {
      if (_currentQuestion.HasOneAnswer)
      {
        _view.VisibleAnswer1 = true;
      }

      SetAnswersColor();
      if (_currentQuestion.IsAnsweredCorrectly(_view))
      {
        _currentQuestion.RepetitionNumber--;
      }
    }

    private void SetAnswersColor()
    {
      //if (_currentQuestion.Answers[0].IsCorrect)
      //{
      //  _view.ColorAnswer1 = Color.Green;
      //}

      //if (_currentQuestion.Answers[1].IsCorrect)
      //{
      //  _view.ColorAnswer2 = Color.Green;
      //}

      //if (_currentQuestion.Answers[2].IsCorrect)
      //{
      //  _view.ColorAnswer3 = Color.Green;
      //}

      //if (_currentQuestion.Answers[3].IsCorrect)
      //{
      //  _view.ColorAnswer4 = Color.Green;
      //}

      //if (_currentQuestion.Answers[4].IsCorrect)
      //{
      //  _view.ColorAnswer5 = Color.Green;
      //}
    }

    public void QuestionLearned()
    {
      _currentQuestion.RepetitionNumber = 0;
    }

    public void SetNextQuestion()
    {
      if (_model.IsAllAnswered())
      {
        SetViewAtQuizEnd();
        return;
      }

      _currentQuestion = GetQuestion();
      SetViewData();
    }

    private void SetViewAtQuizEnd()
    {
      _view.Question = "Poprawnie odpowiedziano na wszystkie pytania";
      _view.Answer1 = String.Empty;
      _view.Answer2 = String.Empty;
      _view.Answer3 = String.Empty;
      _view.Answer4 = String.Empty;
      _view.Answer5 = String.Empty;
      _view.VisibleAnswer1 = false;
      _view.VisibleAnswer2 = false;
      _view.VisibleAnswer3 = false;
      _view.VisibleAnswer4 = false;
      _view.VisibleAnswer5 = false;
      _view.CheckButtonEnabled = false;
      _view.LearnedButtonEnabled = false;
      _view.NextButtonEnabled = false;
    }
  }
}


