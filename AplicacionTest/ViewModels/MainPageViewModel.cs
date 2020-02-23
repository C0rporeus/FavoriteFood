using AplicacionTest.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

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
      AddCommand = new Command(AddCommandExcecute);
    }
    private void AddCommandExcecute()
    {
      MessagingCenter.Send(this, "Add Survey");
    }
  }
}
