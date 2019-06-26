using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ModuleTest3
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new List<Book>()
            {
                new Book(){Name = "LINQ for childrens",Year = 1990, Author = "Jack Daniels"},
                new Book(){Name = "Do not try C#",Year = 2000, Author = "Veuve Clicquot"},
                new Book(){Name = "LINQ is not fun",Year = 2012, Author = "Jack Daniels"},
                new Book(){Name = "Imagination for C#",Year = 1992, Author = "Veuve Clicquot"},
                new Book(){Name = "How get june position",Year = 2019, Author = "Jack Daniels"},
                new Book(){Name ="Some book",Year = 1994, Author = "Jack Daniels"},
            };

            string data2 = "На сегодняшний момент язык программирования C# один из самых мощных, быстро развивающихся и востребованных языков в ИТ-отрасли.";
            int[] data3 = new int[] { 14, 12, 23, 20, 33, 32 };

            //1
            Console.WriteLine(string.Join(Environment.NewLine, data.Where(n => n.Name.Contains("LINQ")&&(DateTime.IsLeapYear(n.Year))).Select(n=>n.Name)));
            Console.WriteLine();
            //2
            Console.WriteLine(string.Join(Environment.NewLine, data2.OfType<string>().ToString().Distinct().Count()));
            Console.WriteLine();
            //3
            Console.WriteLine(string.Join(Environment.NewLine, data3.OrderBy(x=>x/10).ThenByDescending(x => x % 10).ToArray()));
            Console.WriteLine();
            //4
            Console.WriteLine(string.Join(Environment.NewLine, data.GroupBy(a => a.Author).ToDictionary(a=>a.Key, a=>a.ToList().Count())));

        }
    }
}
