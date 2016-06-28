namespace QuizManager.Service.Interface
{
  public interface IQuizReader
  {
    string ReadQuizFromAsset(int repetitionNumber, string textFromResource);

    string ReadQuizFromTextFile(string filePath);    
  }
}