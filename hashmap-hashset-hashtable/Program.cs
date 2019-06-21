using System;
using System.Collections.Generic;

namespace hashmap_hashset_hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new HashSet<String>();
            for (int i = 0; i < 10; i++)
            {
                a.Add("a");
            }

            foreach (var item in a)
            {
                Console.WriteLine(item);
                /* Output
                   a
                 */
            }
        }
    }
}
