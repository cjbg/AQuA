using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
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

      SetButtonCheckClickEvent();
      SetButtonLearnedClickEvent();

      Button buttonNext = FindViewById<Button>(Resource.Id.buttonNext);
      buttonNext.Click += SetNextQuestion;

    }

    private void SetNextQuestion(object sender, EventArgs e)
    {
      _presenter.SetNextQuestion();
    }

    private void SetButtonLearnedClickEvent()
    {
      Button buttonQuestionLearned = FindViewById<Button>(Resource.Id.buttonQuestionLearned);
      buttonQuestionLearned.Click += QuestionLearned;
    }

    private void QuestionLearned(object sender, EventArgs e)
    {
      _presenter.QuestionLearned();
    }

    private void SetButtonCheckClickEvent()
    {
      Button buttonCheck = FindViewById<Button>(Resource.Id.buttonCheck);
      buttonCheck.Click += CheckAnswers;
    }

    private void CheckAnswers(object sender, EventArgs e)
    {
      _presenter.CheckAnswers();
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
        CheckBox checkBoxAnswer1 =
          FindViewById<CheckBox>(Resource.Id.checkBoxAnswer1);
        return checkBoxAnswer1.Text;

      }
      set
      {
        CheckBox checkedTextViewAnwer1 =
          FindViewById<CheckBox>(Resource.Id.checkBoxAnswer1);
        checkedTextViewAnwer1.Text = value;
      }
    }

    public string Answer2
    {
      get
      {
        CheckBox checkBoxAnswer2 =
          FindViewById<CheckBox>(Resource.Id.checkBoxAnswer2);
        return checkBoxAnswer2.Text;

      }
      set
      {
        CheckBox checkBoxAnswer2 =
          FindViewById<CheckBox>(Resource.Id.checkBoxAnswer2);
        checkBoxAnswer2.Text = value;
      }
    }

    public string Answer3
    {
      get
      {
        CheckBox checkBoxAnswer3 =
          FindViewById<CheckBox>(Resource.Id.checkBoxAnswer3);
        return checkBoxAnswer3.Text;

      }
      set
      {
        CheckBox checkBoxAnswer3 =
          FindViewById<CheckBox>(Resource.Id.checkBoxAnswer3);
        checkBoxAnswer3.Text = value;
      }
    }

    public string Answer4
    {
      get
      {
        CheckBox checkBoxAnswer4 =
          FindViewById<CheckBox>(Resource.Id.checkBoxAnswer4);
        return checkBoxAnswer4.Text;

      }
      set
      {
        CheckBox checkBoxAnswer4 =
          FindViewById<CheckBox>(Resource.Id.checkBoxAnswer4);
        checkBoxAnswer4.Text = value;
      }
    }

    public string Answer5
    {
      get
      {
        CheckBox checkBoxAnswer5 =
          FindViewById<CheckBox>(Resource.Id.checkBoxAnswer5);
        return checkBoxAnswer5.Text;

      }
      set
      {
        CheckBox checkBoxAnswer5 =
          FindViewById<CheckBox>(Resource.Id.checkBoxAnswer5);
        checkBoxAnswer5.Text = value;
      }
    }

    public string ColorAnswer1
    {
      set
      {
        CheckBox checkBoxAnswer1 =
          FindViewById<CheckBox>(Resource.Id.checkBoxAnswer1);
        checkBoxAnswer1.SetTextColor(Color.ParseColor(value));
      }
    }

    public string ColorAnswer2
    {
      set
      {
        CheckBox checkBoxAnswer2 =
          FindViewById<CheckBox>(Resource.Id.checkBoxAnswer2);
        checkBoxAnswer2.SetTextColor(Color.ParseColor(value));
      }
    }

    public string ColorAnswer3
    {
      set
      {
        CheckBox checkBoxAnswer3 =
          FindViewById<CheckBox>(Resource.Id.checkBoxAnswer3);
        checkBoxAnswer3.SetTextColor(Color.ParseColor(value));
      }
    }

    public string ColorAnswer4
    {
      set
      {
        CheckBox checkBoxAnswer4 =
          FindViewById<CheckBox>(Resource.Id.checkBoxAnswer4);
        checkBoxAnswer4.SetTextColor(Color.ParseColor(value));
      }
    }

    public string ColorAnswer5
    {
      set
      {
        CheckBox checkBoxAnswer5 =
          FindViewById<CheckBox>(Resource.Id.checkBoxAnswer5);
        checkBoxAnswer5.SetTextColor(Color.ParseColor(value));
      }
    }

    public bool CheckedAnswer1
    {
      get
      {
        CheckBox checkBoxAnswer1 =
          FindViewById<CheckBox>(Resource.Id.checkBoxAnswer1);
        return checkBoxAnswer1.Checked;

      }
      set
      {
        CheckBox checkedTextViewAnwer1 =
          FindViewById<CheckBox>(Resource.Id.checkBoxAnswer1);
        checkedTextViewAnwer1.Checked = value;
      }
    }

    public bool CheckedAnswer2
    {
      get
      {
        CheckBox checkBoxAnswer2 =
          FindViewById<CheckBox>(Resource.Id.checkBoxAnswer2);
        return checkBoxAnswer2.Checked;

      }
      set
      {
        CheckBox checkBoxAnswer2 =
           FindViewById<CheckBox>(Resource.Id.checkBoxAnswer2);
        checkBoxAnswer2.Checked = value;
      }
    }

    public bool CheckedAnswer3
    {
      get
      {
        CheckBox checkBoxAnswer3 =
          FindViewById<CheckBox>(Resource.Id.checkBoxAnswer3);
        return checkBoxAnswer3.Checked;

      }
      set
      {
        CheckBox checkBoxAnswer3 =
          FindViewById<CheckBox>(Resource.Id.checkBoxAnswer3);
        checkBoxAnswer3.Checked = value;
      }
    }

    public bool CheckedAnswer4
    {
      get
      {
        CheckBox checkBoxAnswer4 =
          FindViewById<CheckBox>(Resource.Id.checkBoxAnswer4);
        return checkBoxAnswer4.Checked;

      }
      set
      {
        CheckBox checkBoxAnswer4 =
          FindViewById<CheckBox>(Resource.Id.checkBoxAnswer4);
        checkBoxAnswer4.Checked = value;
      }
    }

    public bool CheckedAnswer5
    {
      get
      {
        CheckBox checkBoxAnswer5 =
          FindViewById<CheckBox>(Resource.Id.checkBoxAnswer5);
        return checkBoxAnswer5.Checked;

      }
      set
      {
        CheckBox checkBoxAnswer5 =
          FindViewById<CheckBox>(Resource.Id.checkBoxAnswer5);
        checkBoxAnswer5.Checked = value;
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
        CheckBox checkBoxAnswer1 =
         FindViewById<CheckBox>(Resource.Id.checkBoxAnswer1);
        checkBoxAnswer1.LayoutParameters.Height = value;
      }
    }

    public bool VisibleAnswer1
    {
      set
      {
        CheckBox checkBoxAnswer1 =
         FindViewById<CheckBox>(Resource.Id.checkBoxAnswer1);
        checkBoxAnswer1.Visibility = value ? ViewStates.Visible : ViewStates.Invisible;
      }
    }

    public bool VisibleAnswer2
    {
      set
      {
        CheckBox checkBoxAnswer2 =
          FindViewById<CheckBox>(Resource.Id.checkBoxAnswer2);
        checkBoxAnswer2.Visibility = value ? ViewStates.Visible : ViewStates.Invisible;
      }
    }

    public bool VisibleAnswer3
    {
      set
      {
        CheckBox checkBoxAnswer3 =
          FindViewById<CheckBox>(Resource.Id.checkBoxAnswer3);
        checkBoxAnswer3.Visibility = value ? ViewStates.Visible : ViewStates.Invisible;
      }
    }

    public bool VisibleAnswer4
    {
      set
      {
        CheckBox checkBoxAnswer4 =
          FindViewById<CheckBox>(Resource.Id.checkBoxAnswer4);
        checkBoxAnswer4.Visibility = value ? ViewStates.Visible : ViewStates.Invisible;
      }
    }

    public bool VisibleAnswer5
    {
      set
      {
        CheckBox checkBoxAnswer5 =
          FindViewById<CheckBox>(Resource.Id.checkBoxAnswer5);
        checkBoxAnswer5.Visibility = value ? ViewStates.Visible : ViewStates.Invisible;
      }
    }
  }
}