﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;

namespace learnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            schoolDirectory();
        }

        static void schoolDirectory()
        {
            Teacher teacher;
            Pupil[] pupil = new Pupil[1000];    // In release code, you'd definitely not
                                                // hardcode this, you'd use a List or similar!

            teacher = new Teacher("John Smith", "L5");

            teacher.eyeColour = Teacher.colour.BLUE;

            Console.Out.WriteLine("Teacher's name is " + teacher.name);

            pupil[0] = new Pupil("James Earl Jones");

            Console.Out.WriteLine("Pupil 0's name is " + pupil[0].name);
        }

        static void doLinkedList()
        {
            LinkedList l;
            ListNode tmp;

            l = new LinkedList(1);

            l.append(5);
            l.append(10);


            /* l.printAll() */

            tmp = l.first;
            Console.Out.WriteLine(tmp.data);
            while ((tmp = tmp.next) != null)
                Console.Out.WriteLine(tmp.data);

            l = null;
        }

        static void Sort(string[] args)
        {
            char response;

            Console.WriteLine("Please let me know what kinda sort you would like (i)nsertion sort, or (b)ubble sort, or (q)uit");
            for (; ; )
            {
                response = Console.ReadKey().KeyChar;
                switch (response)
                {
                    case 'i':
                    case 'I':
                        InsertionSort();
                        break;
                    case 'b':
                    case 'B':
                        BubbleSort();
                        break;
                    case 'q':
                    case 'Q':
                        return;
                    /* NOTREACHED */
                    default:
                        Console.WriteLine("Um, what are you playing at?");
                        break;
                }
            }
        }

        static void BubbleSort()
        {
            // Do the BubbleSort dance here!
        }

        static void InsertionSort()
        {
            var unsortedList = new SortingList(10);
            var sortedList = new SortingList(unsortedList.Length);

            /* Let's fill the unsorted list with all sorts of junk */
            unsortedList.Randomise();
            unsortedList.Print();

            /* This is where we do the insertion sort-- doesn't
             * object oriented make this look easy? */

            for (int i = 0; i < unsortedList.Length; i++)
            {
                sortedList.Insert(unsortedList.Pop());
            }

            sortedList.Print();
        }

        static void bubbleSort()
        {
            int i, j;
            int[] unsortedList, sortedList;
            Random random;
            
            unsortedList = new int[10];
            sortedList = new int[10];
            random = new Random();

            for (i = 0; i < unsortedList.Length; i++)
                unsortedList[i] = random.Next(50);

            /* You can also do Python-style for loops */
            foreach (int num in unsortedList)
                Console.WriteLine(num);

            /* 
                * Copy unsortedList into sortedList
                */

            /* 
                * Iterate over the list, you'll need a couple of counting variables.
                * Above, i and j are declared for you.
                * You should know how to do a bubble sort by now, right? :)
                */
        }
    }
}
