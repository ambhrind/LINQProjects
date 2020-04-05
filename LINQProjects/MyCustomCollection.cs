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

        public MyCustomCollection(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.c = d;
        }

        /// <summary>
        /// yield return for enumerating class as a collection
        /// </summary>
        /// <returns></returns>
        public IEnumerator<int> GetEnumerator()
        {
            yield return a;
            yield return b;
            yield return c;
            yield return d;
        }

        /// <summary>
        /// non generic implementation
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
