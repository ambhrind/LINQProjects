using System;

namespace LINQProjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            var p = new MyCustomCollection(2, 4, 5, 6);

            foreach (var i in p)
            {
                Console.WriteLine(i);
            }
        }
    }
}
