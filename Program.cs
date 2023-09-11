using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1 {
  internal class Program {
    private static void Main(string[] args) {
      List<Drink> drinks = InitializeDrinks();
      AddNewDrink(drinks);
      DisplayDrinks(drinks);
      OrderDrink(drinks, orders);
    }

    // find by name 
    private static void OrderDrink(List<Drink> myDrinks, List<OrderItem> myOrders) {
      Console.WriteLine("Order a drink:");
      Console.Write("Name: ");
      string name = Console.ReadLine();
      Drink drink = myDrinks.Find(d => d.Name == name);
      if (drink == null) {
        Console.WriteLine("Drink not found.");
        return;
      }
      Console.Write("Quantity: ");
      int quantity = int.Parse(Console.ReadLine());
      OrderItem order = new OrderItem() { Drink = drink, Quantity = quantity };
      myOrders.Add(order);
      Console.WriteLine($"Total: {order.Total:C1}");
    }

    private static List<Drink> InitializeDrinks() {
      List<Drink> drinks = new List<Drink> {
        new Drink() { Name = "Coke", Volume = 1, Price = 10,},
        new Drink() { Name = "juice", Volume = 2, Price = 20,},
        new Drink() { Name = "coffee", Volume = 3, Price = 30,},
        new Drink() { Name = "tea", Volume = 4, Price = 40,},
      };
      return drinks;
    }

    private static void DisplayDrinks(List<Drink> drinks) {
      // for (int i=0;i<drinks.Count;i++) {
      //   Console.WriteLine($"Name: {drinks[i].Name}, Volume: {drinks[i].Volume}, Price: {drinks[i].Price}");
      // }
      Console.WriteLine($"{"Name",-5} {"Volume",-3} {"Price",5}");
      foreach (Drink drink in drinks) {
        Console.WriteLine($"Name: {drink.Name,-5}, Volume: {drink.Volume,-3}, Price: {drink.Price,5:C1}");
      }
    }
    private static void AddNewDrink(List<Drink> drinks) {
      Console.WriteLine("Add a new drink:");
      Console.Write("Name: ");
      string name = Console.ReadLine();
      Console.Write("Volume: ");
      int volume = int.Parse(Console.ReadLine());
      Console.Write("Price: ");
      int price = int.Parse(Console.ReadLine());
      drinks.Add(new Drink() { Name = name, Volume = volume, Price = price });
    }
  }
}
