using System;
using System.Collections.Generic;

namespace reverse_linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {

            var llist = new MyLinkedList("aykut", "key1");
            Console.WriteLine(llist);
            Console.ReadLine();
        }



        public class MyLinkedList
        {
            private String _key;
            private Object _obj;
            public MyLinkedList(object value, string key)
            {
                this._key = key;
                this._obj = value;
            }

            void Next()
            {
                
            }

        }
    }
}
