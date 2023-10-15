// See https://aka.ms/new-console-template for more information
//using DayDayLeetCode._2034;
//using DayDayLeetCode._2578;
//using DayDayLeetCode._901;
//using DayDayLeetCode._2731;
//using DayDayLeetCode._2512;
//using DayDayLeetCode._2562;
//using DayDayLeetCode._1488;
using DayDayLeetCode._137;

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
//{
//    StockPrice stockPrice = new StockPrice();
//    stockPrice.Update(1, 10);
//    stockPrice.Update(2, 5);
//    Console.WriteLine(stockPrice.Current());
//    Console.WriteLine(stockPrice.Minimum());
//    Console.WriteLine(stockPrice.Maximum());
//    stockPrice.Update(1, 3);
//    Console.WriteLine(stockPrice.Current());
//    Console.WriteLine(stockPrice.Minimum());
//    Console.WriteLine(stockPrice.Maximum());
//    stockPrice.Update(1, 2);
//    stockPrice.Update(2, 2);
//    stockPrice.Update(3, 2);
//    stockPrice.Update(4, 2);
//    stockPrice.Update(5, 2);
//    stockPrice.Update(6, 2);
//    stockPrice.Update(6, 3);
//    stockPrice.Update(6, 4);
//    stockPrice.Update(6, 1);
//    stockPrice.Update(6, 2);
//    stockPrice.Update(6, 4);
//    Console.WriteLine(stockPrice.Current());
//    Console.WriteLine(stockPrice.Minimum());
//    Console.WriteLine(stockPrice.Maximum());
//}
#endregion

#region 2578
//{
//    Solution solution = new Solution();
//    Console.WriteLine(solution.SplitNum(4325));
//    Console.WriteLine(solution.SplitNum(687));
//}
#endregion

#region 2731
//{
//    Solution solution = new Solution();
//    Console.WriteLine(solution.SumDistance(new int[] { -2, 0, 2 }, "RLL", 3));
//    Console.WriteLine(solution.SumDistance(new int[] { 1, 0 }, "RL", 2));
//}
#endregion

#region 2512 奖励最顶尖的 K 名学生
//{
//    var positive_feedback = new string[] { "fkeofjpc", "qq", "iio" };
//    var negative_feedback = new string[] { "jdh", "khj", "eget", "rjstbhe", "yzyoatfyx", "wlinrrgcm" };
//    var report = new string[] { "rjstbhe eget kctxcoub urrmkhlmi yniqafy fkeofjpc iio yzyoatfyx khj iio", "gpnhgabl qq qq fkeofjpc dflidshdb qq iio khj qq yzyoatfyx", "tizpzhlbyb eget z rjstbhe iio jdh jdh iptxh qq rjstbhe", "jtlghe wlinrrgcm jnkdbd k iio et rjstbhe iio qq jdh", "yp fkeofjpc lkhypcebox rjstbhe ewwykishv egzhne jdh y qq qq", "fu ql iio fkeofjpc jdh luspuy yzyoatfyx li qq v", "wlinrrgcm iio qq omnc sgkt tzgev iio iio qq qq", "d vhg qlj khj wlinrrgcm qq f jp zsmhkjokmb rjstbhe" };
//    var student_id = new int[] { 96537918, 589204657, 765963609, 613766496, 43871615, 189209587, 239084671, 908938263 };
//    var k = 3;
//    Solution solution = new Solution();
//    var result = solution.TopStudents(positive_feedback, negative_feedback, report, student_id, k);
//    Console.WriteLine(string.Join(',', result));
//}
#endregion

#region 2562. 找出数组的串联值
//{
//    Solution solution = new Solution();
//    Console.WriteLine(solution.FindTheArrayConcVal(new int[] { 7, 52, 2, 4 })); ;
//    Console.WriteLine(solution.FindTheArrayConcVal(new int[] { 5, 14, 13, 8, 12 })); ;
//}
#endregion

#region 1488. 避免洪水泛滥
//{
//    Solution solution = new Solution();
//    Console.WriteLine(string.Join(",", solution.AvoidFlood(new int[] { 1, 2, 0, 0, 2, 1 })));
//    Console.WriteLine(string.Join(",", solution.AvoidFlood(new int[] { 1, 2, 3, 4 })));
//    Console.WriteLine(string.Join(",", solution.AvoidFlood(new int[] { 1, 2, 0, 1, 2 })));
//    Console.WriteLine(string.Join(",", solution.AvoidFlood(new int[] { 1, 0, 0, 1, 1 })));
//    Console.WriteLine(string.Join(",", solution.AvoidFlood(new int[] { 1, 2, 0, 0, 0, 1, 2, 1 })));
//    Console.WriteLine(string.Join(",", solution.AvoidFlood(new int[] { 1, 0, 2, 0, 2, 1 })));
//}
#endregion

#region 137
{
    Solution solution = new Solution();
    Console.WriteLine(solution.SingleNumber(new int[] { 2, 2, 3, 2 })); ;
    Console.WriteLine(solution.SingleNumber(new int[] { 0, 1, 0, 1, 0, 1, 99 })); ;
}
#endregion

Console.ReadKey();