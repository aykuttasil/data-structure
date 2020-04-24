using System;
using System.Collections;

namespace stack_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var lst = new int[5] { 34, 30, 29, 36, 44 };
            var stack = new Stack();
            stack.Push("Selam");

            Hashtable h = new Hashtable();
            
            Dictionary s = new Dictionary();
            

            for (int i = 0; i < lst.Length; i++)
            {
                 var stack1 = new Stack();
                 if(lst[i + 1] > lst[i]){
                     stack1.Push(1);
                 }else{
                     stack1.Pop();
                 }
            }

            Console.WriteLine("Hello World!");
        }
    }
}
