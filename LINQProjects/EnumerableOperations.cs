using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQProjects
{
    /// <summary>
    /// A list of various actions that are possible with the Enumerable class
    /// </summary>
    public class EnumerableOperations
    {
        public void EnumerableEmptyOperation()
        {
            //Empty collection
            Console.WriteLine(Enumerable.Empty<int>());
        }

        public void EnumerableRepeat()
        {
            //creates a collection of 4 strings and prints the same
            Console.WriteLine(Enumerable.Repeat("greetings", 4));
        }

        public void EnumerableIntegerRange()
        {
            //returns a range of numbers between the low high index mentioined
            Console.WriteLine(Enumerable.Range(1,10));

            //taking this a little further with a more interesting implementation
            //How about printing 'x''s and not the count in the collection like above
            Console.WriteLine(Enumerable.Range(1, 10)
                .Select(i => new string('x', i)));
        }

        public void EnumerableCharacterRange()
        {
            //Enumerable.range works on Integers. Following code witll covert chars to ascii values and then 
            //cast that to characters through a lambda expression
            Console.WriteLine(Enumerable.Range('a', 'z' - 'a')
                .Select(c => (char)c));
        }
    }
}
