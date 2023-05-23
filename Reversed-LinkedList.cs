using System;

namespace ConsoleApp1
{
    class LinkedListRev
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
            if (head == null)
            {
                head = newNode;
                return;
            }
            newNode.next = head;
            head = newNode;
        }
        void ReverseNodes()
        {
            if(head == null || head.next == null)
            {
                return;
            }
            Node prevNode = head;
            Node currNode = head.next;

            while(currNode != null)
            {
                Node nextNode = currNode.next;
                currNode.next = prevNode;

                prevNode = currNode;
                currNode = nextNode;
            }
            head.next = null;
            head = prevNode;
        }
        void printNodes()
        {
            Node ctrl = head;
            while(ctrl != null)
            {
                Console.Write(ctrl.data + " -> ");
                ctrl = ctrl.next;
            }
            Console.WriteLine("NULL");
        }
        public static void Main(string[] args)
        {
            LinkedListRev list = new LinkedListRev();
            list.AddFront(10);
            list.AddFront(15);
            list.AddFront(20);
            list.AddFront(25);
            list.printNodes();

            Console.WriteLine("Reversed Linked list:");
            list.ReverseNodes();
            list.printNodes();

            Console.ReadKey();
        }
    }
}
