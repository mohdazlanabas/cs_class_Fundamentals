// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// ANNOYNAMOUS TYPES

var v = new { Amount = 108, Message = "Hello" };

// Rest the mouse pointer over v.Amount and v.Message in the following
// statement to verify that their inferred types are int and string.
Console.WriteLine(v.Amount + v.Message);


var anonArray = new[] { new { name = "apple", diam = 4 }, new { name = "grape", diam = 1 } };

var apple = new { Item = "apples", Price = 1.35 };
var onSale = apple with { Price = 0.79 };
Console.WriteLine(apple);
Console.WriteLine(onSale);