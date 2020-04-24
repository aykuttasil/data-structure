using System;

namespace stack_implementation_linkedlist
{
    class Program
    {

        class Node
        {
            public Node next;
            public int data;

            public Node(int value)
            {
                this.data = value;
            }
        }

        class StackDataStructure
        {

            Node head;
            public void push(int value)
            {
                Node newNode = new Node(value);

                if (head == null)
                {
                    head = newNode;
                    return;
                }

                newNode.next = head;
                head = newNode;
            }

            public int pop()
            {
                int topValue = head.data;
                head = head.next;
                return topValue;
            }

            internal void printList()
            {
                var temp = head;
                while (temp != null)
                {
                    Console.WriteLine("-> " + temp.data.ToString());
                    temp = temp.next;
                }
                Console.WriteLine("--");
            }
        }

        static void Main(string[] args)
        {

            StackDataStructure stackData = new StackDataStructure();
            stackData.push(1);
            stackData.push(2);
            stackData.push(3);

            stackData.printList();

            stackData.push(4);
            stackData.push(5);
            stackData.push(6);
            stackData.push(7);
            stackData.pop();
            stackData.push(8);

            stackData.printList();

            stackData.printList();
        }
    }
}
