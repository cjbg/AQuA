using System;
using System.Collections.Generic;
using System.Linq;
using QuizManager.Model;
using static System.Char;

namespace QuizManager.Service
{
  public class QuizParser : IQuizParser
  {
    private const string HasOneAnswerMark = "1";

    public List<Question> ParseQuestions(List<string> lines, int repetitionNumber)
    {
      var questions = new List<Question>();
      Question question = new Question();
      string[] validAnswers = { string.Empty };

      foreach (var line in lines)
      {
        if (string.IsNullOrWhiteSpace(line))
        {
          continue;
        }
        if (IsQuestionLine(line))
        {
          question = SetQuestion(line, repetitionNumber);
        }
        else if (IsAnswerMark(line))
        {
          validAnswers = line.Split(':')[1]
            .Split(',');
        }
        else if (IsLastAnswerLine(line))
        {
          AddAnswer(question, line);
          SetValidAnswers(question, validAnswers);

          questions.Add(question);
        }
        else if (IsAnswerLine(line))
        {
          AddAnswer(question, line);
        }
      }

      return questions;
    }

    private void SetValidAnswers(Question question, string[] validAnswers)
    {
      if (validAnswers[0] == HasOneAnswerMark)
      {
        question.Answers[0].IsCorrect = true;
        question.HasOneAnswer = true;
      }
      else
      {
        question.Answers.ForEach(
          x => x.IsCorrect = validAnswers.Any(
            y => y == GetFirstLetter(x.Name).ToString()));
      }
    }

    private bool IsLastAnswerLine(string line)
    {
      return IsAnswerLine(line)
             && GetFirstLetter(line) == 'E';
    }

    private bool IsAnswerMark(string line)
    {
      return line.Contains("ODP:");
    }

    private bool IsAnswerLine(string line)
    {
      char firstLetter = GetFirstLetter(line);
      char seccondLetter = Convert.ToChar(line.Trim()[1]);

      return IsLetter(firstLetter)
        && IsPunctuation(seccondLetter);
    }

    private static bool IsQuestionLine(string line)
    {
      char firstLetter = GetFirstLetter(line);
      return IsDigit(firstLetter);
    }

    private static char GetFirstLetter(string line)
    {
      return Convert.ToChar(line.Trim()[0]);
    }

    private Question SetQuestion(string line, int repetitionNumber)
    {
      Question question = new Question();      

      question.Name = line;
      question.RepetitionNumber = repetitionNumber;
      question.Answers = new List<Answer>();

      return question;
    }

    private void AddAnswer(Question question, string line)
    {
      Answer answer = new Answer();
      answer.Name = line;

      question.Answers.Add(answer);
    }    
  }
}
