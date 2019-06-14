using System;

namespace queue_with_linkedlist
{

    class Node
    {
        public Job Data { get; set; }
        public Node Next { get; set; }
    }


    class Job
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }

    }

    class Program
    {
        static Node head = new Node();
        static Node temp;

        public static Node createNode(string id, string name, int priority)
        {
            Job j = new Job();
            j.Id = id;
            j.Name = name;
            j.Priority = priority;

            var node = new Node();
            node.Data = j;
            node.Next = null;
            return node;
        }

        public static void addNode(Node node)
        {
            if (head.Data == null)
            {
                head = node;
            }
            else
            {
                addFirst(node);
                // addLast(node);
            }
        }

        public static void addFirst(Node node)
        {
            node.Next = head;
            head = node;
        }

        public static void addLast(Node node)
        {
            // Console.WriteLine("addLast Node: " + node.Data.Id);

            temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = node;
        }

        public static void printNodes()
        {
            var t = head;

            while (t.Next != null)
            {
                Console.WriteLine(t.Data.Id);
                t = t.Next;
            }
            Console.WriteLine(t.Data.Id);
        }

        static void Main(string[] args)
        {
            addNode(createNode("1", "q", 1));
            addNode(createNode("2", "w", 1));
            addNode(createNode("3", "e", 2));
            addNode(createNode("4", "r", 3));
            addNode(createNode("5", "t", 1));
            addNode(createNode("6", "y", 2));

            // Console.WriteLine(head.Data.Id);
            Console.WriteLine("-------------");
            printNodes();

            Console.ReadLine();
        }
    }
}
