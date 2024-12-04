using System;
using System.Collections.Generic;
using Microsoft.Maui.Controls.Shapes;
using SQLite;
using System.IO;
using System.Linq;
using Path = System.IO.Path;

namespace RestaurantPicker.Models;

public class Repository
{

    private readonly SQLiteConnection _database;
    
    public Repository()
    {
        var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "restaurants.db");

        _database = new SQLiteConnection(dbPath);
        _database.CreateTable<Restaurant>();
    }

    public List<Restaurant> GetRestaurants()
    {
        return _database.Table<Restaurant>().ToList();
    }

    public void SaveRestaurant(Restaurant restaurant)
    {
        _database.Insert(restaurant);
    }

    public Restaurant GetRandom()
    {
        return _database.Query<Restaurant>("Select * from Restaurant order by Random() LIMIT 1").FirstOrDefault();
    }
    
}