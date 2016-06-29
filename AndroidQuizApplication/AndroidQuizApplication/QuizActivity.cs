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
      get
      {
        TextView questionTextView = 
          FindViewById<TextView>(Resource.Id.textViewQuestion);
        return questionTextView.Text;
      }
      set
      {
        TextView questionTextView = 
          FindViewById<TextView>(Resource.Id.textViewQuestion);
        questionTextView.Text = value;
      }
    }

    public string Answer1
    {
      get
      {
        CheckedTextView checkedTextViewAnwer1 = 
          FindViewById<CheckedTextView>(Resource.Id.checkedTextViewAnswer1);
        return checkedTextViewAnwer1.Text;

      }
      set
      {
        CheckedTextView checkedTextViewAnwer1 = 
          FindViewById<CheckedTextView>(Resource.Id.checkedTextViewAnswer1);
        checkedTextViewAnwer1.Text = value;
      }
    }

    public string Answer2
    {
      get
      {
        CheckedTextView checkedTextViewAnwer2 =
          FindViewById<CheckedTextView>(Resource.Id.checkedTextViewAnswer2);
        return checkedTextViewAnwer2.Text;

      }
      set
      {
        CheckedTextView checkedTextViewAnwer2 =
          FindViewById<CheckedTextView>(Resource.Id.checkedTextViewAnswer2);
        checkedTextViewAnwer2.Text = value;
      }
    }

    public string Answer3
    {
      get
      {
        CheckedTextView checkedTextViewAnwer3 =
          FindViewById<CheckedTextView>(Resource.Id.checkedTextViewAnswer3);
        return checkedTextViewAnwer3.Text;

      }
      set
      {
        CheckedTextView checkedTextViewAnwer3 =
          FindViewById<CheckedTextView>(Resource.Id.checkedTextViewAnswer3);
        checkedTextViewAnwer3.Text = value;
      }
    }

    public string Answer4
    {
      get
      {
        CheckedTextView checkedTextViewAnwer4 =
          FindViewById<CheckedTextView>(Resource.Id.checkedTextViewAnswer4);
        return checkedTextViewAnwer4.Text;

      }
      set
      {
        CheckedTextView checkedTextViewAnwer4 =
          FindViewById<CheckedTextView>(Resource.Id.checkedTextViewAnswer4);
        checkedTextViewAnwer4.Text = value;
      }
    }

    public string Answer5
    {
      get
      {
        CheckedTextView checkedTextViewAnwer5 =
          FindViewById<CheckedTextView>(Resource.Id.checkedTextViewAnswer5);
        return checkedTextViewAnwer5.Text;

      }
      set
      {
        CheckedTextView checkedTextViewAnwer5 =
          FindViewById<CheckedTextView>(Resource.Id.checkedTextViewAnswer5);
        checkedTextViewAnwer5.Text = value;
      }
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