// See https://aka.ms/new-console-template for more information

using CoffeeShopConsoleAppNet60;

BlackCoffee blackcoffee = new BlackCoffee();
Latte latte = new Latte();
Cortado cortado = new Cortado();

List<Coffee> coffeelist = new List<Coffee>();

coffeelist.Add(blackcoffee);
coffeelist.Add(latte);
coffeelist.Add(cortado);

foreach (Coffee coffee in coffeelist)
{
    Console.WriteLine($"{coffee}: Strenght: {coffee.Strenght()}. Price: {coffee.Price()}");
}

