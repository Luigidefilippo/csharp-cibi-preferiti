﻿Console.WriteLine("Hello, This is my favorite food !");

string[] FavoriteFood = { "Pizza", "Cheesborger", "Pasta", "Ice-Creme", "Sushi" };

Console.WriteLine(FavoriteFood.Length);

Console.WriteLine("This is my ranking of my favorite foods:");

for (int i = 0; i < FavoriteFood.Length; i++)
{
    Console.WriteLine(FavoriteFood[i]);
}

//First Favorite food
Console.WriteLine("My First favorite food is " + FavoriteFood[0]);

