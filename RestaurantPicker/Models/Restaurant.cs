using SQLite;

namespace RestaurantPicker.Models;

public class Restaurant
{
    [PrimaryKey, AutoIncrement]
    public int ID { get; set; }
    
    public string Name { get; set; }
    
    public string Type { get; set; }
}