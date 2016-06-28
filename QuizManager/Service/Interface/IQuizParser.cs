using System.Collections.Generic;
using QuizManager.Model;

namespace QuizManager.Service
{
  public interface IQuizParser
  {
    List<Question> ParseQuestions(List<string> lines, int repetitionNumber);
  }
}