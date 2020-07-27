using System;
using System.Collections.Generic;
using System.Text;

namespace Tema5si6
{
    public class Ex15
    {
        public class Node
        {
            public int data;
            public Node next;

            public Node(int nodeData)
            {
                this.data = nodeData;
                this.next = null;
            }
        }
        class LinkedList
        {
            public Node head;

            public LinkedList()
            {
                this.head = null;
            }
            public void insert(int nodeData)
            {
                Node node = new Node(nodeData);

                if (this.head != null)
                {
                    node.next = head;
                }
                this.head = node;
            }
        }
        public static void printLinkedList(Node node, string sep)

        {
            while (node != null)
            {
                Console.Write(node.data + sep);
                node = node.next;
            }
        }
        static Node Reverse(Node head)
        {
            if (head == null)
            {
                return head;
            }
            if (head.next == null)
            {
                return head;
            }

            Node newHeadNode = Reverse(head.next);
            head.next.next = head;
            head.next = null;
            return newHeadNode;
        }
        public  void ex15()
        {
            LinkedList list = new LinkedList();

            list.insert(1);
            list.insert(2);
            list.insert(3);
            list.insert(4);

            Console.WriteLine("Linked list:");
            printLinkedList(list.head, " ");
            Console.WriteLine("\nReversed Linked list:");
            Node list1 = Reverse(list.head);
            printLinkedList(list1, " ");
        }
    }
}
    

