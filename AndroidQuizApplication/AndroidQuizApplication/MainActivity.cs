using System;
using System.IO;
using Android.App;
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

      Button buttonStart = FindViewById<Button>(Resource.Id.buttonStart);
      buttonStart.Click += OnStartClick;

      _presenter = new MenuPresenter(this);
    }

    private void OnStartClick(object sender, EventArgs e)
    {
      string text = _presenter.ReadQuiz();
      var output = FindViewById<EditText>(Resource.Id.editTextOutput);
      output.Text = text;
    }   
  }
}

