using AplicacionTest.Models;
using AplicacionTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AplicacionTest.ViewModels
{
  public class MainPageViewModel : NotificationObject
  {
    private ObservableCollection<Survey> surveys;

    public ObservableCollection<Survey> Surveys 
    { 
      get { return surveys;  }
      set { 
        surveys = value;
        OnPropertyChanged();
      } 
    }
    public ICommand AddCommand 
      { get; set; }

    public MainPageViewModel()
    {
      Surveys = new ObservableCollection<Survey>();
      AddCommand = new Command(AddCommandExcecute);

      MessagingCenter.Subscribe<SurveyDetailsViewModel, Survey>(this, "SaveSurvey", (a, s) =>
      {
        Surveys.Add(s);
      });
    }
    private void AddCommandExcecute()
    {
      MessagingCenter.Send(this, "Add Survey");
    }
  }
}
