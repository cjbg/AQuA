using System.Collections.Generic;
using QuizManager.Model;

namespace QuizManager.Service.Interface
{
  public interface IQuizReader
  {
    List<Question> ReadQuizFromResource(int repetitionNumber, string textFromResource);

    string ReadQuizFromTextFile(string filePath);

    string GetQuizSetText(QuizSet quizSet, string filePath);
  }
}