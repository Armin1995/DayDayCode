// See https://aka.ms/new-console-template for more information
using DayDayCore;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

MyDbContext myDbContext = new MyDbContext();

//for (int i = 0; i < 10; i++)
//{
//    var nameChar = char.ConvertFromUtf32('A' + i);
//    var age = Random.Shared.Next(1, 100);

//    var d = new Dog() { Name = $"Dog{nameChar}", Age = age };
//    myDbContext.Dogs.Add(d);

//    var p = new Person() { Name = $"Person{nameChar}", Age = age };
//    myDbContext.Persons.Add(p);

//    var b = new Book() { Author = $"Person{nameChar}", Description = $"Description{nameChar}", Title = $"Title{nameChar}" };
//    myDbContext.Books.Add(b);
//}

var dogs = myDbContext.Dogs.Where(o => o.Age > 10);
//低效率
//await dogs.ForEachAsync(o => o.Age += 1);
//await myDbContext.SaveChangesAsync();
//高效率
await dogs.ExecuteUpdateAsync(o => o.SetProperty(v => v.Age, e => e.Age + 1).SetProperty(v => v.Name, e => e.Name + 1));
