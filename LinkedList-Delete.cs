using System;

namespace ConsoleApp1
{
    class LinkedListRem
    {
        Node head;
        class Node
        {
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
                this.next = null;
            }
        }
        void Insert(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }

            newNode.next = head;
            head = newNode;
        }
        void DeleteFirst()
        {
            if (head == null)
            {
                Console.WriteLine("The list is empty");
                return;
            }
            head = head.next;
        }
        void DeleteLast()
        {
            if (head == null)
            {
                Console.WriteLine("The list is empty");
                return;
            }
            if (head.next == null)
            {
                head = null;
                return;
            }

            Node secondLast = head;
            Node last = head.next;

            while (last.next != null)
            {
                last = last.next;
                secondLast = secondLast.next;
            }
            secondLast.next = null;
        }

        void PrintList()
        {
            if (head == null)
            {
                Console.WriteLine("The list is empty");
                return;
            }
            Node ctrlNode = head;
            while (ctrlNode != null)
            {
                Console.Write(ctrlNode.data + " -> ");
                ctrlNode = ctrlNode.next;
            }
            Console.WriteLine("NULL");
        }
        
        public static void Main(string[] args)
        {
            LinkedListRem list = new LinkedListRem();
            list.Insert(7);
            list.Insert(8);
            list.Insert(9);
            list.Insert(10);
            list.Insert(11);
            list.PrintList();

            list.DeleteLast();
            list.PrintList();

            list.DeleteFirst();
            list.PrintList();

            Console.ReadLine();
        }
    }
}
