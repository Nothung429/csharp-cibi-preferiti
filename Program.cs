﻿// See https://aka.ms/new-console-template for more information

string[] foods = { "riso patate e cozze", "pizza", "hamburger", "sushi", "pokè", "piadina", "involtini", "pollo"};

int lengthOfFoods = foods.Length;

Console.WriteLine(lengthOfFoods);

for(var i = 0; i < lengthOfFoods; i++)
{
    Console.WriteLine(foods[i]);
};

string favourite = foods.First();

Console.WriteLine(favourite);

string hated = foods.Last();

Console.WriteLine(hated);