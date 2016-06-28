using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Android.Content.Res;

namespace QuizManager.View.Interface
{
  public interface IMenuView
  {
    bool ShuffleAnswers { get; }

    bool HideAnswerLetter { get; }

    string RepetitionNumberText { get; }    

    AssetManager Assets { get; }
  }
}
