// See https://aka.ms/new-console-template for more information

string[] foods = { "riso patate e cozze", "pizza", "hamburger", "sushi", "pokè", "piadina", "involtini", "pollo", "cipolla"};

int lengthOfFoods = foods.Length;
Console.WriteLine($"Lunghezza lista: {lengthOfFoods}");

for (var i = 0; i < lengthOfFoods; i++)
{
    Console.WriteLine(foods[i]);
};

string favourite = foods.First();
Console.WriteLine($"Cibo preferito: {favourite}");

string hated = foods.Last();
Console.WriteLine($"Cibo odiato: {hated}");

if(lengthOfFoods % 2 == 0)
{
    int im = lengthOfFoods / 2;
    int im1 = lengthOfFoods / 2 - 1;
    string mediana = $"{foods[im]} e {foods[im1]}";
    Console.WriteLine($"Cibo mediano pari: {mediana}");
}
else
{
    int im = lengthOfFoods / 2;
    string mediana = foods[im];
    Console.WriteLine($"Cibo mediano dispari: {mediana}");
}