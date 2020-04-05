using System;

namespace LINQProjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            var p = new MyCustomCollection(2, 4, 5, 6);
            var n = new EnumerateSpecificFields("sean", "kenny", "johnson", 32, "male");

            foreach (var i in p)
            {
                Console.WriteLine(i);
            }

            foreach (string name in n.Names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
