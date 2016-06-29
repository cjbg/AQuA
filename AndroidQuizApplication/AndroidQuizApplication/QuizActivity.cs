using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using QuizManager.Model;
using QuizManager.Presenter;
using QuizManager.View.Interface;

namespace AndroidQuizApplication
{
  [Activity(Label = "QuizActivity")]
  public class QuizActivity : Activity, IQuizView
  {
    private QuizPresenter _presenter;

    protected override void OnCreate(Bundle bundle)
    {
      base.OnCreate(bundle);
      SetContentView(Resource.Layout.Quiz);

      var quizSet = GetQuizSet();
      _presenter = MakeQuizPresenter(quizSet);


    }

    private QuizSet GetQuizSet()
    {
      QuizSet quizSet = new QuizSet();
      string quizName = Intent.GetStringExtra(PassedDataResources.QuizName);
      string quizValue = Intent.GetStringExtra(PassedDataResources.QuizValue);
      
      quizSet.Name = quizName;
      quizSet.Value = quizValue;
      return quizSet;
    }

    private QuizPresenter MakeQuizPresenter(QuizSet quizSet)
    {
      return new QuizPresenter(false, false, "1", quizSet, string.Empty, this);
    }

    public string Question
    {
      get { throw new NotImplementedException(); }
      set { throw new NotImplementedException(); }
    }

    public string Answer1
    {
      get { throw new NotImplementedException(); }
      set { throw new NotImplementedException(); }
    }

    public string Answer2
    {
      get { throw new NotImplementedException(); }
      set { throw new NotImplementedException(); }
    }

    public string Answer3
    {
      get { throw new NotImplementedException(); }
      set { throw new NotImplementedException(); }
    }

    public string Answer4
    {
      get { throw new NotImplementedException(); }
      set { throw new NotImplementedException(); }
    }

    public string Answer5
    {
      get { throw new NotImplementedException(); }
      set { throw new NotImplementedException(); }
    }

    public bool CheckedAnswer1
    {
      get { throw new NotImplementedException(); }
      set { throw new NotImplementedException(); }
    }

    public bool CheckedAnswer2
    {
      get { throw new NotImplementedException(); }
      set { throw new NotImplementedException(); }
    }

    public bool CheckedAnswer3
    {
      get { throw new NotImplementedException(); }
      set { throw new NotImplementedException(); }
    }

    public bool CheckedAnswer4
    {
      get { throw new NotImplementedException(); }
      set { throw new NotImplementedException(); }
    }

    public bool CheckedAnswer5
    {
      get { throw new NotImplementedException(); }
      set { throw new NotImplementedException(); }
    }

    public bool CheckButtonEnabled
    {
      get { throw new NotImplementedException(); }
      set { throw new NotImplementedException(); }
    }

    public bool LearnedButtonEnabled
    {
      get { throw new NotImplementedException(); }
      set { throw new NotImplementedException(); }
    }

    public bool NextButtonEnabled
    {
      get { throw new NotImplementedException(); }
      set { throw new NotImplementedException(); }
    }

    public int HeightAnswer1
    {
      set { throw new NotImplementedException(); }
    }

    public bool VisibleAnswer1
    {
      set { throw new NotImplementedException(); }
    }

    public bool VisibleAnswer2
    {
      set { throw new NotImplementedException(); }
    }

    public bool VisibleAnswer3
    {
      set { throw new NotImplementedException(); }
    }

    public bool VisibleAnswer4
    {
      set { throw new NotImplementedException(); }
    }

    public bool VisibleAnswer5
    {
      set { throw new NotImplementedException(); }
    }
  }
}