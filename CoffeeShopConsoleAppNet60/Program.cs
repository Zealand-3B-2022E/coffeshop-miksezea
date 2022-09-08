// See https://aka.ms/new-console-template for more information

using CoffeeShopConsoleAppNet60;

BlackCoffee blackcoffee = new BlackCoffee(1);
Latte latte = new Latte(5);
Cortado cortado = new Cortado(3);

List<Coffee> coffeelist = new List<Coffee>();

coffeelist.Add(blackcoffee);
coffeelist.Add(latte);
coffeelist.Add(cortado);

foreach (Coffee coffee in coffeelist)
{
    Console.WriteLine($"{coffee.CoffeeType()}: Strength: {coffee.Strength()}. Price: {coffee.Price()}");
}

