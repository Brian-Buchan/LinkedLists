using System;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList myList = new LinkedList();
            bool running = true;

            while (running)
            {
                switch (Ask())
                {
                    case "A":
                        AddStart();
                        break;
                    case "B":
                        AddEnd();
                        break;
                    case "C":
                        DeleteStart();
                        break;
                    case "D":
                        Print();
                        break;
                    case "E":
                        running = false;
                        break;
                    default:
                        break;
                }
            }
        }

        private static void AddStart()
        {

        }

        private static void AddEnd()
        {

        }

        private static void DeleteStart()
        {

        }

        private static void Print()
        {

        }

        private static string Ask()
        {
            Console.WriteLine("Add to Start: A /n Add to End: B /n Remove at Start: C /n Print List: D /n Exit: E");
            return Console.ReadLine();
        }
    }

    class LinkedList
    {
        private Node head;
        private Node current;
        public int Count;

        public LinkedList()
        {
            head = new Node();
            current = head;
        }

        public void AddAtLast(object data)
        {
            Node newNode = new Node();
            newNode.Value = data;
            current.Next = newNode;
            current = newNode;
            Count++;
        }

        public void AddAtStart(object data)
        {
            Node newNode = new Node() { Value = data };
            newNode.Next = head.Next;
            head.Next = newNode;
            Count++;
        }

        public void RemoveFromStart()
        {
            if (Count > 0)
            {
                head.Next = head.Next.Next;
                Count--;
            }
            else
            {
                Console.WriteLine("No element exist in this linked list.");
            }
        }

        public void PrintAllNodes()
        {
            //Traverse from head
            Console.Write("Head ->");
            Node curr = head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write(curr.Value);
                Console.Write("->");
            }
            Console.Write("NULL");
        }
    }

    class Node
    {
        public Node Next;
        public Object Value;
    }
}