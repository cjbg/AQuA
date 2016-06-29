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
      get
      {
        CheckedTextView checkedTextViewAnwer1 =
          FindViewById<CheckedTextView>(Resource.Id.checkedTextViewAnswer1);
        return checkedTextViewAnwer1.Checked;

      }
      set
      {
        CheckedTextView checkedTextViewAnwer1 =
          FindViewById<CheckedTextView>(Resource.Id.checkedTextViewAnswer1);
        checkedTextViewAnwer1.Checked = value;
      }
    }

    public bool CheckedAnswer2
    {
      get
      {
        CheckedTextView checkedTextViewAnwer2 =
          FindViewById<CheckedTextView>(Resource.Id.checkedTextViewAnswer2);
        return checkedTextViewAnwer2.Checked;

      }
      set
      {
        CheckedTextView checkedTextViewAnwer2 =
          FindViewById<CheckedTextView>(Resource.Id.checkedTextViewAnswer2);
        checkedTextViewAnwer2.Checked = value;
      }
    }

    public bool CheckedAnswer3
    {
      get
      {
        CheckedTextView checkedTextViewAnwer3 =
          FindViewById<CheckedTextView>(Resource.Id.checkedTextViewAnswer3);
        return checkedTextViewAnwer3.Checked;

      }
      set
      {
        CheckedTextView checkedTextViewAnwer3 =
          FindViewById<CheckedTextView>(Resource.Id.checkedTextViewAnswer3);
        checkedTextViewAnwer3.Checked = value;
      }
    }

    public bool CheckedAnswer4
    {
      get
      {
        CheckedTextView checkedTextViewAnwer4 =
          FindViewById<CheckedTextView>(Resource.Id.checkedTextViewAnswer4);
        return checkedTextViewAnwer4.Checked;

      }
      set
      {
        CheckedTextView checkedTextViewAnwer4 =
          FindViewById<CheckedTextView>(Resource.Id.checkedTextViewAnswer4);
        checkedTextViewAnwer4.Checked = value;
      }
    }

    public bool CheckedAnswer5
    {
      get
      {
        CheckedTextView checkedTextViewAnwer5 =
          FindViewById<CheckedTextView>(Resource.Id.checkedTextViewAnswer5);
        return checkedTextViewAnwer5.Checked;

      }
      set
      {
        CheckedTextView checkedTextViewAnwer5 =
          FindViewById<CheckedTextView>(Resource.Id.checkedTextViewAnswer5);
        checkedTextViewAnwer5.Checked = value;
      }
    }

    public bool CheckButtonEnabled
    {
      get
      {
        Button buttonCheck =
          FindViewById<Button>(Resource.Id.buttonCheck);
        return buttonCheck.Enabled;
      }
      set
      {
        Button buttonCheck =
          FindViewById<Button>(Resource.Id.buttonCheck);
        buttonCheck.Enabled = value;
      }
    }

    public bool LearnedButtonEnabled
    {
      get
      {
        Button buttonLearned =
          FindViewById<Button>(Resource.Id.buttonQuestionLearned);
        return buttonLearned.Enabled;
      }
      set
      {
        Button buttonLearned =
           FindViewById<Button>(Resource.Id.buttonQuestionLearned);
        buttonLearned.Enabled = value;
      }
    }

    public bool NextButtonEnabled
    {
      get
      {
        Button buttonNext =
          FindViewById<Button>(Resource.Id.buttonNext);
        return buttonNext.Enabled;
      }
      set
      {
        Button buttonNext =
          FindViewById<Button>(Resource.Id.buttonNext);
        buttonNext.Enabled = value;
      }
    }

    public int HeightAnswer1
    {
      set
      {
        CheckedTextView checkedTextViewAnwer1 =
         FindViewById<CheckedTextView>(Resource.Id.checkedTextViewAnswer1);
        checkedTextViewAnwer1.LayoutParameters.Height = value;
      }
    }

    public bool VisibleAnswer1
    {
      set
      {
        CheckedTextView checkedTextViewAnwer1 =
         FindViewById<CheckedTextView>(Resource.Id.checkedTextViewAnswer1);
        checkedTextViewAnwer1.Visibility = value ? ViewStates.Visible : ViewStates.Invisible;
      }
    }

    public bool VisibleAnswer2
    {
      set
      {
        CheckedTextView checkedTextViewAnwer2 =
         FindViewById<CheckedTextView>(Resource.Id.checkedTextViewAnswer2);
        checkedTextViewAnwer2.Visibility = value ? ViewStates.Visible : ViewStates.Invisible;
      }
    }

    public bool VisibleAnswer3
    {
      set
      {
        CheckedTextView checkedTextViewAnwer3 =
         FindViewById<CheckedTextView>(Resource.Id.checkedTextViewAnswer3);
        checkedTextViewAnwer3.Visibility = value ? ViewStates.Visible : ViewStates.Invisible;
      }
    }

    public bool VisibleAnswer4
    {
      set
      {
        CheckedTextView checkedTextViewAnwer4 =
         FindViewById<CheckedTextView>(Resource.Id.checkedTextViewAnswer4);
        checkedTextViewAnwer4.Visibility = value ? ViewStates.Visible : ViewStates.Invisible;
      }
    }

    public bool VisibleAnswer5
    {
      set
      {
        CheckedTextView checkedTextViewAnwer5 =
         FindViewById<CheckedTextView>(Resource.Id.checkedTextViewAnswer5);
        checkedTextViewAnwer5.Visibility = value ? ViewStates.Visible : ViewStates.Invisible;
      }
    }
  }
}