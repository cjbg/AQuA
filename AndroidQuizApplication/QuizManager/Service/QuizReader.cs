using System;
using QuizManager.Service.Interface;

namespace QuizManager.Service
{
  public class QuizReader: IQuizReader
  {
    public string ReadQuizFromAsset(int repetitionNumber, string textFromResource)
    {
      throw new NotImplementedException();
    }

    public string ReadQuizFromTextFile(string filePath)
    {
      throw new NotImplementedException();
    }
  }
}