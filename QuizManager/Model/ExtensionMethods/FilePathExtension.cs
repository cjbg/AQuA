using System.IO;

namespace QuizManager.Model.ExtensionMethods
{
  public static class FilePathExtension
  {
    public static bool IsFileExtensionValid(this string filePath)
    {
      string extension = Path.GetExtension(filePath);
      if (extension == "txt")
      {
        return true;
      }

      return false;
    }
  }
}
