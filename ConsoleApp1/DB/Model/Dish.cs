﻿namespace ConsoleApp1.DB.Model;

public class Dish
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public int TypeDishId { get; set; }
}