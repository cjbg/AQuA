using System;
using System.IO;
using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Widget;
using Android.OS;
using QuizManager.Presenter;
using QuizManager.View.Interface;

namespace AndroidQuizApplication
{
  [Activity(Label = "AndroidQuizApplication", MainLauncher = true, Icon = "@drawable/icon")]
  public class MainActivity : Activity, IMenuView
  {
    private MenuPresenter _presenter;

    public bool ShuffleAnswers
    {
      get { throw new NotImplementedException(); }
    }

    public bool HideAnswerLetter
    {
      get { throw new NotImplementedException(); }
    }

    public string RepetitionNumberText
    {
      get { throw new NotImplementedException(); }
    }

    protected override void OnCreate(Bundle bundle)
    {
      base.OnCreate(bundle);      
      SetContentView(Resource.Layout.Main);

      _presenter = new MenuPresenter(this);

      Button buttonStart = FindViewById<Button>(Resource.Id.buttonStart);
      buttonStart.Click += OnStartClick;
    }

    private void OnStartClick(object sender, EventArgs e)
    {
      var quizActivity = new Intent(this, typeof(QuizActivity));
      PassQuizSet(quizActivity);
      StartActivity(quizActivity);
    }

    private static void PassQuizSet(Intent quizActivity)
    {
      //TODO: data from comboBox
      quizActivity.PutExtra(PassedDataResources.QuizName, "Pytania 1-114");
      quizActivity.PutExtra(PassedDataResources.QuizValue, "Questions_1_114");
    }
  }
}

