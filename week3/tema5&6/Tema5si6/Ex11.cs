using System;
using System.Collections.Generic;
using System.Text;

namespace Tema5si6
{ 
        //How to find the 3rd element from the end, in a singly linked, in a single pass?
        public class LinkedList
        {
            public Node head;
            public class Node
            {
                public int data;
                public Node next;
                public Node(int d)
                {
                    data = d;
                    next = null;
                }
            }
            void print3rdFromLast(int n)
            {
                int len = 0;
                Node temp = head;
                while (temp != null)
                {
                    temp = temp.next;
                    len++;
                }
                if (len < n)
                    return;

                temp = head;
                for (int i = 1; i < len - n + 1; i++)
                    temp = temp.next;

                Console.WriteLine(temp.data);
            }
            public void push(int new_data)
            {
                Node new_node = new Node(new_data);
                new_node.next = head;
                head = new_node;
            }
            public void ex11()
            {
                LinkedList list = new LinkedList();
                list.push(1);
                list.push(2);
                list.push(3);
                list.push(4);
                list.print3rdFromLast(3);
            }
        }
 }

