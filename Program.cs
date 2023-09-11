// Console.WriteLine("input a number");
// int num = Convert.ToInt32(Console.ReadLine());
// for (int i=1;i<=9;i++) {
//   for (int j=1;j<=i;j++) {
//     Console.Write($"{i}x{j}={i*j} ");
//   }
//   Console.WriteLine();
// }

using System.Drawing;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleAPP1 {
  internal class Program {
    private static void Main(string[] args) {
      List<Drink> drinks = new List<Drink>();
      // Drink drink1 = new Drink() { Name = "Coke", Size = 500, Price = 10,};
      // drinks.Add(drink1);
      drinks.Add(new Drink() { Name = "Coke", Size = 1, Price = 10,});
      drinks.Add(new Drink() { Name = "juice", Size = 2, Price = 20,});
      drinks.Add(new Drink() { Name = "coffee", Size = 3, Price = 30,});
      drinks.Add(new Drink() { Name = "Coke", Size = 4, Price = 40,});
    }
    
  }
}






// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// string afriend = "YEEET";
// string bfriend = "YeeEET";
// Console.WriteLine($"Hello {afriend} and {bfriend}");
// Console.WriteLine($"frienda: {afriend} has {afriend.Length} characters");
// Console.WriteLine($"friendb: {bfriend} has {bfriend.Length} characters");

// Console.WriteLine("Hello, World!");
// string afriend = "YEEET";
// string bfriend = "YeeEET";
// Console.WriteLine($"Hello {afriend} and {bfriend}");
// Console.WriteLine($"frienda: {afriend} has {afriend.Length} characters");
// Console.WriteLine($"friendb: {bfriend} has {bfriend.Length} characters");


// string greeting = "   Hello World!   ";
// Console.WriteLine($"[{greeting}]");
// string trimmedGreeting = greeting.TrimStart();
// Console.WriteLine($"[{trimmedGreeting}]");
// trimmedGreeting = greeting.TrimEnd();
// Console.WriteLine($"[{trimmedGreeting}]");
// trimmedGreeting = greeting.Trim();
// Console.WriteLine($"[{trimmedGreeting}]");


// string sayHello = "Hello lllllll!";
// Console.WriteLine(sayHello);

// sayHello = sayHello.Replace("Hello", "Greetings");
// Console.WriteLine(sayHello);


// string songLyrics = "You say goodbye, and I say hello";
// Console.WriteLine(songLyrics.Contains("goodbye"));
// Console.WriteLine(songLyrics.Contains("greetings"));