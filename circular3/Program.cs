using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circular3
{
    class Node
    {
        /* cretes node for the circular nexted lisst*/
        public int rollNumber;
        public string name;
        public Node next;
    }

    class CircularList
    {
        Node LAST;

        public CircularList()
        {
            LAST = null;
        }

        public bool search(int rollNo, ref Node previous, ref Node current)
        /*Searches for the specified node*/
        {
            for (previous = current = LAST.next; current != LAST; previous = current, current = current.next)
            {
                if (rollNo == current.rollNumber)
                    return (true);/* returns true if the node is found*/
            }
            if (rollNo == LAST.rollNumber)/* if the node is present at the end*/
                return true;
            else
                return false;/* return false if the node is not found*/
        }
        public bool listEmpty()
        {
            if (LAST == null)
                return true;
            else
                return false;
        }
        public void traverse()/* traverse all the nodes of the list*/
        {
            if (listEmpty())
                Console.WriteLine("\nList is empty");
            else
            {
                Console.WriteLine("\nRecord in the list are:\n");
                Node currentNode;
                currentNode = LAST.next;
                while (currentNode != LAST)
                {
                    Console.Write(currentNode.rollNumber + "  " + currentNode.name + "\n");
                    currentNode = currentNode.next;
                }
                Console.Write(LAST.rollNumber + "   " + LAST.name + "\n");
            }
        }
        public void firstNode()
        {
            if (listEmpty())
                Console.WriteLine("\nList is empty");
            else
            {
                Console.WriteLine("\nThe firs ricord in the list is:\n\n" +
                    LAST.next.rollNumber + "   " + LAST.next.name);
            }
        }

        public void descending()
        {
            if (listEmpty())
                Console.WriteLine("\nList empty");
            else
            {

                Console.WriteLine("\nRecord in the descading order of" + "roll number are: \n");
                Node currentNode;
                for (currentNode = LAST; currentNode != null; currentNode = currentNode.next) { }

                while (currentNode != null)
                {
                    Console.WriteLine(currentNode.rollNumber + "" + currentNode.name + "\n");
                    currentNode = currentNode.next;
                }
            }
        }

        public void ascending()
        {
            if (listEmpty())
                Console.WriteLine("\nList empty");
            else
            {

                Console.WriteLine("\nRecord in the descading order of" + "roll number are: \n");
                Node currentNode;
                for (currentNode = LAST; currentNode != null; currentNode = currentNode.next)
                    Console.WriteLine(currentNode.rollNumber + "" + currentNode.name + "\n");
            }
        }

        class program
        {
            static void Main(string[] args)
            {
                CircularList obj = new CircularList();
                while (true)
                {
                    try
                    {
                        Console.WriteLine("\nMenu");
                        Console.WriteLine("1. viuw all the ricords in the list");
                        Console.WriteLine("2. search for a ricord in the list ");
                        Console.WriteLine("3. display the first ricord in the list ");
                        Console.WriteLine("4. Exit");
                        Console.WriteLine("\nEnter your choice (1-4): ");
                        char ch = Convert.ToChar(Console.ReadLine());
                        switch (ch)
                        {
                            case '1':
                                {
                                    obj.traverse();
                                }
                                break;
                            case '2':
                                {
                                    if (obj.listEmpty() == true)
                                    {
                                        Console.WriteLine("\nList is empty");
                                        break;
                                    }
                                    Node prev, curr;
                                    prev = curr = null;
                                    Console.Write("\nEnter the roll number of the student whese record is to be serched: ");
                                    int num = Convert.ToInt32((Console.ReadLine()));
                                    if (obj.search(num, ref prev, ref curr) == false)
                                        Console.WriteLine("\nRecord not found");
                                    else
                                    {
                                        Console.WriteLine("\nRecord found");
                                        Console.WriteLine("\nRoll Number: " + curr.rollNumber);
                                        Console.WriteLine("\nName: " + curr.name);
                                    }
                                }
                                break;
                            case '3':
                                {
                                    obj.firstNode();
                                }
                                break;
                            case '4':
                                return;
                            default:
                                {
                                    Console.WriteLine("invalid option");
                                    break;
                                }
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }
            }
        }
    }
}

