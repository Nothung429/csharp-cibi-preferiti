// See https://aka.ms/new-console-template for more information

string[] foods = { "riso patate e cozze", "pizza", "hamburger", "sushi", "pokè", "piadina", "involtini", "pollo"};

int lengthOfFoods = foods.Length;
Console.WriteLine("Lunghezza lista");
Console.WriteLine(lengthOfFoods);

for (var i = 0; i < lengthOfFoods; i++)
{
    Console.WriteLine(foods[i]);
};

string favourite = foods.First();
Console.WriteLine("Cibo preferito");
Console.WriteLine(favourite);

string hated = foods.Last();
Console.WriteLine("Cibo odiato");
Console.WriteLine(hated);