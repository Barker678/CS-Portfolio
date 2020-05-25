using System;
using System.Collections.Generic;

namespace Portfolio
{
    class Program
    {
        private readonly int[] array = new int[20];
        private static void quick(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Part(arr, left, right);

                if (pivot > 1)
                {
                    quick(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    quick(arr, pivot + 1, right);
                }
            }
        }
        private static int Part(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    if (arr[left] == arr[right])
                        return right;
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Bubble sort");
            Console.WriteLine("");
            int[] a = { 20, 10, 50, 40, 90, 70, 60, 1, -1, 192, 42 };
            int b;
            Console.WriteLine("Original Array is : ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(" " + a[i]);
            }
            for (int c = 0; c <= a.Length - 2; c++)
            {
                for (int i = 0; i <= a.Length - 2; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        b = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = b;
                    }
                }
            }
            Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("The Bubble sort : ");
            foreach (int aray in a)
                Console.Write(aray + " ");
            Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Insert sort");
            Console.WriteLine("");
            int[] arr = { 10, 20, 30, 40, 90, 70, 60, 55, 92, 11, -2 };
            int d;
            Console.WriteLine("Original Array is : ");
            for (d = 0; d < arr.Length; d++)
            {
                Console.Write(" " + arr[d]);
            }
            Console.ReadLine();
            int[] num = arr;
            for (int i = 1; i < num.Length; i++)
            {
                int item = num[i];
                int m = i - 1;
                while (m >= 0 && num[m] > item)
                {
                    num[m + 1] = num[m];
                    m--;
                }
                num[m + 1] = item;
            }
            Console.WriteLine("");
            Console.WriteLine("Insert Sort: ");
            foreach (var item in num)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
            Console.WriteLine("");
            //Doesn't quite work properly
            //new radix().Radixsort();
            //Console.ReadLine();

            Console.WriteLine("Stack Push, Peek and Pop: ");
            Console.WriteLine("");
            Stack newStack = new Stack();
            newStack.push("Folkestone");
            newStack.Peek();
            newStack.pop();
            newStack.push("Canterbury");
            newStack.Peek();
            newStack.pop();
            Console.ReadLine();
   

            Console.WriteLine("Queue Enqueue, Dequeue and PrintQueue: ");
            Console.WriteLine("");
            Queue newQueue = new Queue();
            newQueue.Enqueue("Ashford");
            newQueue.Enqueue("Hawkinge");
            newQueue.Enqueue("Capel-le-ferne");
            newQueue.PrintQueue();
            newQueue.Dequeue();
            Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Linked List: ");

            LinkedList linkedList = new LinkedList(1);
            linkedList.next = new LinkedList(9);
            linkedList.next.next = new LinkedList(6);
            linkedList.Print();
            Console.ReadLine();
            Console.WriteLine("");

            Stack anotherStack = new Stack();
            anotherStack.push("_________________________________________________________________");
            anotherStack.pop();
            anotherStack.push("  _      _                                            __         ");
            anotherStack.pop();
            anotherStack.push("  |  |  /    /                            /    /    /    )()/    ");
            anotherStack.pop();
            anotherStack.push("--|-/|-/----/__----__----__------__------/____/----/----/--/-----");
            anotherStack.pop();
            anotherStack.push("  |/ |/    /   ) /   ) /   )   /   )         /    /    /  /()    ");
            anotherStack.pop();
            anotherStack.push("__/__|____/___/_(___/_(___/___/___/_________/____(____/__________");
            anotherStack.pop();
            anotherStack.push("                             /                                   ");
            anotherStack.pop();
            anotherStack.push("                           /                                     ");
            anotherStack.pop();
            anotherStack.push("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            anotherStack.pop();
            Console.WriteLine("Thanks for viewing and have a good day!!!");
            Console.ReadLine();
            
        }
    }
}
