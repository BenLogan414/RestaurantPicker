using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using RestaurantPicker.Models;

namespace RestaurantPicker.Views;

public partial class AddPage : ContentPage
{
    public AddPage()
    {
        InitializeComponent();
    }


    private void AddRestaurant_OnClicked(object sender, EventArgs e)
    {
        var newRestaurant = new Restaurant();
        newRestaurant.Name = txtName.Text;
        newRestaurant.Type = txtType.Text;
        
        App.RestaurantList.SaveRestaurant(newRestaurant);

        txtName.Text = string.Empty;
        txtType.Text = string.Empty;
    }
}