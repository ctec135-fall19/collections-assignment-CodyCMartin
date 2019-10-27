/*Author: Cody Martin
 Class: CTEC 135 Week 5
 Task: Programming Assignment 4
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_and_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            #region prob 1 simple array & list<t>

            //create an array of int of size 5
            //use a for loop to initialize it to the numbers 11 - 15
            //use a foreach loop to print out the values in the array

            int[] simpArray = new int[5];
            for (int i = 0; i < simpArray.Length; i++)
            {
                simpArray[i] = i + 11;
                Console.WriteLine(simpArray[i]);
            }
            Console.WriteLine();

            //create a list of int
            //use a for loop to initialize the list to the numbers 21 - 25
            //use a foreach loop to print out the values in the list
            //update the values in the list to 31 - 35 using indexing
            //repeat the print using a for loop and indexing

            List<int> listInt = new List<int>();

            for (int j = 0; j < 5; j++)
            {
                listInt.Add(j + 21);
                Console.WriteLine(listInt[j]);
            }
            Console.WriteLine();

            //update the values in the list to 31 - 35 using indexing
            //repeat the print using a for loop and indexing

            for (int j = 0; j < 5; j++)
            {
                listInt[j] = (j + 31);
                Console.WriteLine(listInt[j]);
            }
            Console.WriteLine();

            #endregion

            #region prob 2 Stacks and Queues

            //declare and initialize a stack with the numbers 1 - 5 using initialization syntax.
            //demonstrate use of the enumerator to print out the members in the stack, i.e.write a foreach loop
            Stack<int> stackInt = new Stack<int>();

            for (int j = 1; j < 6; j++)
            {
                stackInt.Push(j);
                Console.WriteLine(stackInt.Peek());
            }
            Console.WriteLine();

            foreach (int i in stackInt)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();



            //print a peek at the top member in the stack

            Console.WriteLine(stackInt.Peek());
            Console.WriteLine();

            //write a loop that pops the elements off of the stack and prints each
            int size = stackInt.Count;
            for (int j = 1; j < size; j++)
            {
                stackInt.Pop();
                Console.WriteLine(stackInt.Peek());
            }

            Console.WriteLine();



            //declare a queue
            //initialize the queue with the numbers 1 - 5 using a for loop.

            Queue<int> queInt = new Queue<int>();

            for (int j = 1; j < 6; j++)
            {
                queInt.Enqueue(j);
                Console.WriteLine(j);
            }
            Console.WriteLine();

            //demonstrate use of the enumerator to print out the members in the queue, i.e. write a foreach loop

            foreach (int i in queInt)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            //print a peek at the top member in the 

            Console.WriteLine(queInt.Peek());
            Console.WriteLine();


            //write a loop that dequeues the elements from the stack and prints each

            for (int j = 1; j < 6; j++)
            {
                queInt.Dequeue();
                Console.WriteLine(queInt.Count);
            }
            Console.WriteLine();

            #endregion

            #region Prob 3 Dictionary

            //declare a dictionary and initialization it to create 3 entries: (1, "one"), (2, "two"), and(3, "three").
            //Use a combination of initialization syntax, Add() and[] in your initialization code.
            //add an additional entry: (99, "ninety-nine")

            Dictionary<int, string> dictInt = new Dictionary<int, string>();
            dictInt[1] = "one";
            dictInt[2] = "two";
            dictInt.Add(3, "three");
            dictInt[99] = "ninety-nine";



            //show use of enumerator to see all entries. Print both the key and value



            foreach (int i in dictInt.Keys)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine();
            foreach (string j in dictInt.Values)
            {
                Console.WriteLine(j);

            }
            Console.WriteLine();


            //reassign the value of 99 to "99" using indexing notation
            //print the new value using indexing notation
            dictInt[99] = "99";
            Console.WriteLine(dictInt[99]);


            //remove the 2 item and enumerate over the whole dictionary to show it's gone

            dictInt.Remove(1);
            dictInt.Remove(2);

            foreach (int i in dictInt.Keys)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine();
            foreach (string j in dictInt.Values)
            {
                Console.WriteLine(j);

            }
            Console.WriteLine();

            #endregion

            #region prob 4 linked list
            //Demonstrate use of constructor taking an IEnumerable object.
            //Create a string array having the first 5 - 10 words of your favorite nursery rhyme. 
            string[] array = new string[] { "mary", "had", "a", "little", "lamb", };

            //Use it as the argument when constructing the LinkedList object.
            LinkedList<string> linList = new LinkedList<string>(array);

            //Print out the rhyme on a single line.
            foreach (string i in linList)
            {
                Console.Write("{0} ",i);

            }
            Console.WriteLine();

            //The traditional way to walk a linked list is to start at the head, process the node, then set the node variable to the next node in the list. 
            //Create a node variable and walk the list to print out the values. The line printed should be the same as the one above.

            LinkedListNode<String> node = linList.First;
            while (node != null)
            {
                Console.Write("{0} ",node.Value);
                node = node.Next;
            }
            Console.WriteLine();



            //Remove a word from the middle of the list. Print the list on a single line to demonstrate this
            linList.Remove("mary");

            foreach (string i in linList)
            {
                Console.Write("{0} ", i);

            }
            Console.WriteLine();

            //Add the word back in and print the list again to demonstrate.

            linList.AddFirst("mary");
            foreach (string i in linList)
            {
                Console.Write("{0} ", i);

            }
            Console.WriteLine();





            #endregion
        }
    }
}
