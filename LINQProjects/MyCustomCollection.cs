using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LINQProjects
{
    /// <summary>
    /// Want to do a FOREACH on my own custom collection. 
    /// This demonstrates how IEnumerable can enable a class to be enumerated like a collection
    /// </summary>
    public class MyCustomCollection : IEnumerable<int>
    {
        private int a, b, c, d;

        public MyCustomCollection(int a1, int b1, int c1, int d1)
        {
            a = a1;
            b = b1;
            c = c1;
            d = d1;
        }
        public IEnumerator<int> GetEnumerator()
        {
            yield return a;
            yield return b;
            yield return c;
            yield return d;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
