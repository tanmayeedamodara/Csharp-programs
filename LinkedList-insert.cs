using System;

namespace ConsoleApp1
{
    class LinkedList
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
        void AddFront(int data)
        {
            Node newNode = new Node(data);
            if(head == null)
            {
                head = newNode;
                return;
            }

            newNode.next = head;
            head = newNode;
        }
        void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node currNode = head;
            while(currNode.next != null)
            {
                currNode = currNode.next;
            }
            currNode.next = newNode;
        }
        void AddAtIndex(int position, int data)
        {
            int ctr = 1;
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }

            Node currNode = head;
            while(currNode.next != null)
            {
                if(ctr+1 == position)
                {
                    newNode.next = currNode.next;
                    currNode.next = newNode;
                }
                ctr++;
                currNode = currNode.next;
            }

        }

        void printList()
        {
            if(head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node node = head;
            while(node != null)
            {
                Console.Write(node.data + " -> ");
                node = node.next;
            }
            Console.WriteLine("NULL");
        }

        public static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.printList();

            list.AddFront(20);
            list.AddFront(10);
            list.printList();

            list.AddLast(30);
            list.AddLast(40);
            list.printList();


            list.AddAtIndex(2, 15);
            list.AddAtIndex(5, 35);
            list.printList();
            Console.ReadLine();
        }
    }
}
