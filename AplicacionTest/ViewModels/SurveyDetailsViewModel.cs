using AplicacionTest.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AplicacionTest.ViewModels
{
  class SurveyDetailsViewModel : NotificationObject
  {
    private string name;
    public string Name
    {
      get { return name; }
      set { name = value;
        OnPropertyChanged();
      }
    }

    private string favoriteFood;

    public string FavoriteFood
    {
      get { return favoriteFood; }
      set { string favoriteFood = value; }
    }

    public ICommand SaveCommand { get; set; }

    public SurveyDetailsViewModel()
    {
      SaveCommand = new Command(() => 
      {
        var newSurvey = new Survey() 
        { 
          Name = this.Name,
          FavoriteFoot = this.FavoriteFood
        };
        MessagingCenter.Send(this, "SaveSurvey", newSurvey); 
      });
    }
  }
}
