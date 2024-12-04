using System.Collections.Generic;
using Microsoft.Maui.Controls;
using RestaurantPicker.Models;

namespace RestaurantPicker;

public partial class App : Application
{
    //public static List<Restaurant> RestaurantList;
    public static Repository RestaurantList;
    
    public App()
    {
        InitializeComponent();
        //RestaurantList = new List<Restaurant>();
        RestaurantList = new Repository();
        MainPage = new AppShell();
    }
}