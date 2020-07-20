using System;

namespace UpdateTema4
{
    class Exercitiul3
    {
            //3.Write code to remove duplicates from an unsorted linked list.
            public class Node
            {
            public int data;
            public Node next;
            public Node previously;
            }
        static Node delete(Node head, Node del)
        {
            if (head == null || del == null)
                return head;
            
            if (head == del)
                head = del.next;
            
            if (del.next != null)
                del.next.previously = del.previously;
            
            if (del.previously != null)
                del.previously.next = del.next;
                return head;
        }
        static Node removeDuplicates(Node head)
        {
            if ((head) == null || (head).next == null)
            {
                return head;
            }
            Node ptr1, ptr2;
            for (ptr1 = head;
                ptr1 != null; ptr1 = ptr1.next)
            {
                ptr2 = ptr1.next;               
                while (ptr2 != null)
                {                 
                    if (ptr1.data == ptr2.data)
                    { 
                        Node next = ptr2.next;
                        head = delete(head, ptr2);
                        ptr2 = next;
                    }
                    else
                        ptr2 = ptr2.next;
                }
            }
            return head;
        }
        static Node push(Node head, int input)
        { 
            Node new_node = new Node();

            new_node.data = input;
            new_node.previously = null; 
            new_node.next = (head);
            if ((head) != null)
                (head).previously = new_node;
                (head) = new_node;
                return head;           
        }
        static void printList(Node head)
        {
            if (head == null)
            {
                Console.Write("Doubly Linked list empty");
            }
            while (head != null)
            {
                Console.Write(head.data + " ");
                head = head.next;
            }
        }
        public void exercitiul3()
        {
            Node head = null;
            head = push(head, 1);
            head = push(head, 2);
            head = push(head, 3);
            head = push(head, 4);
            head = push(head, 4);
            head = push(head, 5);
            head = push(head, 6);
            head = push(head, 7);
            head = push(head, 8);
            head = push(head, 8);
            Console.WriteLine("The list before removal:");
            printList(head);
            head = removeDuplicates(head);
            Console.WriteLine("\nThe list after removal:");
            printList(head);
            Console.ReadKey();
        }
    }



}
 