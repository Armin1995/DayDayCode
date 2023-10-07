// See https://aka.ms/new-console-template for more information
using DayDayLeetCode._901;

Console.WriteLine("Hello, World!");

StockSpanner stockSpanner = new StockSpanner();
Console.WriteLine(stockSpanner.Next(100));
Console.WriteLine(stockSpanner.Next(80));
Console.WriteLine(stockSpanner.Next(60));
Console.WriteLine(stockSpanner.Next(70));
Console.WriteLine(stockSpanner.Next(60));
Console.WriteLine(stockSpanner.Next(75));
Console.WriteLine(stockSpanner.Next(85));

Console.ReadKey();