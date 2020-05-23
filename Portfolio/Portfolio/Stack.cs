using System;
using System.Collections;

namespace Portfolio
{
    class Stack
    {

        private int index;
        public ArrayList list;
        public Stack()
        {
            list = new ArrayList();
            index = -1;
        }
        public int count
        {
            get
            {
                return list.Count;
            }
        }
        public void push(object item)
        {
            list.Add(item);
            index++;
        }
        public object pop()
        {
            object obj = list[index];
            list.RemoveAt(index);
            index--;
            return obj;
        }
        public void clear()
        {
            list.Clear();
            index = -1;
        }
        public object peek()
        {
            return list[index];
        }


    }
    public class LinkedList
    {
        class Node
        {
            public Node(object value)
            {
                Content = value;
            }

            public object Content;
            public Node Next = null;
        }

        private int ListLength = 0;

        private Node head;

        public LinkedList()
        {
            head = new Node("");
        }

        public LinkedList(object value)
        {
            head = new Node("");
            Node newNode = new Node(value);
            head.Next = newNode;
            ListLength = 1;
        }

        public object getHeadContent()
        {
            if (head.Next == null)
            {
                return "Nothing in list";
            }
            else
            {
                return head.Next.Content;
            }
        }

        public object getNodeContent(int nodeIndex)
        {
            Node currentNode = head;
            for (int i = 0; i < nodeIndex + 1; i++)
            {
                currentNode = currentNode.Next;
            }
            return currentNode.Content;
        }

        public object GetTailContent()
        {
            Node currentNode = head;
            for (int i = 0; i <= Length() - 1; i++)
            {
                currentNode = currentNode.Next;
            }
            return currentNode.Content;
        }

        public void AddNodeBeginning(object value)
        {
            Node newNode = new Node(value);
            newNode.Next = head.Next;
            head.Next = newNode;
            ListLength += 1;
        }

        public void AddNodeInList(int insertAfterPoint, object newNodeValue)
        {
            Node currentNode = head;
            if (insertAfterPoint == 0)
            {
                // add to beginning 
                AddNodeBeginning(newNodeValue);
                return;
            }
            if (Length() > insertAfterPoint) // check if index is a valid one
            {
                for (int i = 0; i < Length(); i++) // loop through the list 
                {
                    if (i == insertAfterPoint)
                    {
                        Node newNode = new Node(newNodeValue);
                        newNode.Next = currentNode.Next;
                        currentNode.Next = newNode;
                        ListLength += 1;
                    }
                    currentNode = currentNode.Next;
                }
            }
            else
            {
                Console.WriteLine("List is not " + insertAfterPoint.ToString() + " in legnth, so can not insert at this point.");
            }
        }

        public void RemoveNodeEnd()
        {
            if (Length() >= 1) // check the list isn't empty
            {
                Node currentNode = head;
                Node lastNode = null;
                while (currentNode.Next != null)
                {
                    lastNode = currentNode;
                    currentNode = currentNode.Next;
                }
                lastNode.Next = null;
                ListLength -= 1;
            }
            else { Console.WriteLine("No items in list"); }
        }

        public void RemoveNodeInList(int nodeToDelete)
        {
            Node currentNode = head;
            Node lastNode = null;
            for (int i = 0; i <= nodeToDelete; i++)
            {
                if (i == nodeToDelete)
                {
                    lastNode = currentNode;
                    currentNode = currentNode.Next;
                    lastNode.Next = currentNode.Next;
                    ListLength -= 1;
                }
            }
        }

        public void PrintList()
        {
            if (head.Next == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Node currentNode = head.Next;
            while (currentNode.Next != null)
            {
                Console.WriteLine("Value: " + currentNode.Content.ToString());
                currentNode = currentNode.Next;
            }
            Console.WriteLine("Value: " + currentNode.Content.ToString());

        }


        // Iterative version of the Length function
        public int LengthIterative()
        {
            if (head == null)
            {
                return 0;
            }

            Node currentNode = head;
            int count = 0;

            while (currentNode.Next != null)
            {
                count++;
                currentNode = currentNode.Next;
            }

            return count;
        }

        // Non-iterative version
        public int Length()
        {
            return ListLength;
        }
        class Queue
        {
            private LinkedList Q = new LinkedList();

            public Queue()
            {

            }

            public void Enqueue(object element)
            {
                Q.AddNodeBeginning(element);
            }

            public object Dequeue()
            {
                object temp = Q.GetTailContent();
                Q.RemoveNodeEnd();
                return temp;
            }

            public void PrintQueue()
            {
                Q.PrintList();
            }

            public int Length()
            {
                return Q.Length();
            }
        }
        class program
        {
            public static void Main(string[] args)
            {
                Stack alist = new Stack();
                string ch;
                string word = ("racecar");
                bool palindrome = true;
                for (int x = 0; x < word.Length; x++)
                    alist.push(word.Substring(x, 1));
                int pos = 0;
                while (alist.count > 0)
                {
                    ch = alist.pop().ToString();
                    if (ch != word.Substring(pos, 1))
                    {
                        palindrome = false;
                        break;
                    }
                    pos++;
                }
                if (palindrome)
                    Console.WriteLine(word + " is a palindrome.");
                else
                    Console.WriteLine(word + " isn't a palindrome");
                Console.Read();

            }
        }
    }
}
