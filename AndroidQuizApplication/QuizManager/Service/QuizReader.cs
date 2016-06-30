using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using QuizManager.Model;
using QuizManager.Properties;
using QuizManager.Service.Interface;

namespace QuizManager.Service
{
  public class QuizReader : IQuizReader
  {
    private readonly IQuizParser _parser;    

    public QuizReader()
      : this(new QuizParser())
    {      
    }

    public QuizReader(IQuizParser parser)
    {
      _parser = parser;
    }

    public List<Question> ReadQuizFromResource(int repetitionNumber, string textFromResource)
    {
      string resourceData = textFromResource;

      List<string> lines = resourceData.Split(
          new[] { "\r\n" }, 
          StringSplitOptions.RemoveEmptyEntries)
        .ToList();

      return _parser.ParseQuestions(lines, repetitionNumber);
    }
    public string ReadQuizFromTextFile(string filePath)
    {
      using (StreamReader reader = new StreamReader(filePath, Encoding.Default))
      {
        return reader.ReadToEnd();
      }
    }

    //TODO: OpenClose principle
    public string GetQuizSetText(QuizSet quizSet, string filePath)
    {
      switch (quizSet.Value)
      {
        case QuizSets.Questions_1_114:
          return Resources.Fizjologia_Pytania_1_114;
        case QuizSets.Questions_115_294:
          return Resources.Fizjologia_Pytania_115_294;
        case QuizSets.Questions_W1W2W3W4:
          return Resources.W1W2W3W4;
        case QuizSets.QuestionsFromPictures:
          return Resources.Kolokwium_z_fozjologii_układ_pokarmowy;
        case QuizSets.FromFile:
          return ReadQuizFromTextFile(filePath);
        default:
          return string.Empty;
      }
    }
  }
}
