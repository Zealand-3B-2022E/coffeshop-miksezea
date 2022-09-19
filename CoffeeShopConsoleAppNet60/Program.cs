// See https://aka.ms/new-console-template for more information

using CoffeeShopConsoleAppNet60;

BlackCoffee blackcoffee1 = new BlackCoffee(1);
BlackCoffee blackcoffee2 = new BlackCoffee(4);
Latte latte1 = new Latte(5);
Latte latte2 = new Latte(2);
Cortado cortado1 = new Cortado(3);
Cortado cortado2 = new Cortado();

List<Coffee> coffeelist = new List<Coffee>();

coffeelist.Add(blackcoffee1);
coffeelist.Add(blackcoffee2);
coffeelist.Add(latte1);
coffeelist.Add(latte2);
coffeelist.Add(cortado1);
coffeelist.Add(cortado2);

Console.WriteLine("List of coffees:");
foreach (Coffee coffee in coffeelist)
{
    Console.WriteLine($"{coffee.CoffeeType()}: Strength: {coffee.Strength()}. Price: {coffee.Price()}");
}

List<IMilk> milklist = new List<IMilk>();

milklist.Add(latte1);
milklist.Add(latte2);
milklist.Add(cortado1);
milklist.Add(cortado2);

/*
foreach (IMilk milkcoffee in milklist)
{
    Console.WriteLine($"{coffee.CoffeeType()}: Strength: {coffee.Strength()}. Price: {coffee.Price()}. Milk amount: ");
}
*/

