// See https://aka.ms/new-console-template for more information
using DayDayLeetCode._2034;
using DayDayLeetCode._901;

Console.WriteLine("Hello, World!");

#region 901
//{
//    StockSpanner stockSpanner = new StockSpanner();
//    Console.WriteLine(stockSpanner.Next(100));
//    Console.WriteLine(stockSpanner.Next(80));
//    Console.WriteLine(stockSpanner.Next(60));
//    Console.WriteLine(stockSpanner.Next(70));
//    Console.WriteLine(stockSpanner.Next(60));
//    Console.WriteLine(stockSpanner.Next(75));
//    Console.WriteLine(stockSpanner.Next(85));
//}
#endregion

#region 2034
{
    StockPrice stockPrice = new StockPrice();
    stockPrice.Update(1, 10);
    stockPrice.Update(2, 5);
    Console.WriteLine(stockPrice.Current());
    Console.WriteLine(stockPrice.Minimum());
    Console.WriteLine(stockPrice.Maximum());
    stockPrice.Update(1, 3);
    Console.WriteLine(stockPrice.Current());
    Console.WriteLine(stockPrice.Minimum());
    Console.WriteLine(stockPrice.Maximum());
    stockPrice.Update(1, 2);
    stockPrice.Update(2, 2);
    stockPrice.Update(3, 2);
    stockPrice.Update(4, 2);
    stockPrice.Update(5, 2);
    stockPrice.Update(6, 2);
    stockPrice.Update(6, 3);
    stockPrice.Update(6, 4);
    stockPrice.Update(6, 1);
    stockPrice.Update(6, 2);
    stockPrice.Update(6, 4);
    Console.WriteLine(stockPrice.Current());
    Console.WriteLine(stockPrice.Minimum());
    Console.WriteLine(stockPrice.Maximum());
}
#endregion

Console.ReadKey();