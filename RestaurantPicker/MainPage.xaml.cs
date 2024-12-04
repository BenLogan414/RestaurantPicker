using System;
using System.Collections.Generic;
using Microsoft.Maui.Controls;
using RestaurantPicker.Models;

namespace RestaurantPicker;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void GetRestaurant_OnClicked(object sender, EventArgs e)
    {
        var randomRestaurant = App.RestaurantList.GetRandom();

        DisplayAlert(randomRestaurant.Name, randomRestaurant.Type, "OK");
    }
}