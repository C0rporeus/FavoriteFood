using System;
using System.Collections.Generic;
using System.Text;

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

  }
}
