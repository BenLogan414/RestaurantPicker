using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace RestaurantPicker.Views;

public partial class ListPage : ContentPage
{
    public ListPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        var moveTemplate = new DataTemplate(typeof(TextCell));
        moveTemplate.SetBinding(TextCell.TextProperty,"Name");
        moveTemplate.SetBinding(TextCell.DetailProperty,"Type");

        lstRestaurants.ItemTemplate = moveTemplate;
        lstRestaurants.ItemsSource = App.RestaurantList.GetRestaurants();
    }
}