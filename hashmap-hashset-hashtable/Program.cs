using System;
using System.Collections.Generic;

namespace hashmap_hashset_hashtable
{
    class Program
    {
        static void Main(string[] args)
        {

            sampleHashSet();
            sampleHashMap();

        }

        public static void sampleHashSet()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("HashSet");

            var a = new HashSet<String>();
            for (int i = 0; i < 10; i++)
            {
                a.Add("a" + 1);
                a.Add("a" + 1);
            }

            foreach (var item in a)
            {
                Console.WriteLine(item);
                /* Output
                   a
                 */
            }
            Console.WriteLine("-------------------");
        }

        public static void sampleHashMap()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("HashMap");

            var a = new Dictionary<int, string>();
            for (int i = 0; i < 10; i++)
            {
                a.Add(i, "a" + i);
                // a.Add(i, "a" + i); Runtime Error. Because it's must be once for same key.
            }

            foreach (var item in a)
            {
                Console.WriteLine(item.Value);
                /* Output
                   a
                 */
            }
            Console.WriteLine("-------------------");
        }
    }
}
