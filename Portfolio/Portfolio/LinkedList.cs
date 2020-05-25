using System;


namespace Portfolio
{
    public class LinkedList
    {
        public int data;
        public LinkedList next;
        public LinkedList(int i)
        {
            data = i;
            next = null;
        }
        public void Print()
        {
            Console.WriteLine("Numbers in list: " + data);
            if(next != null)
            {
                next.Print();
            }
        }

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

        private readonly Node head;

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

        public object GetHeadContent()
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

        public object GetNodeContent(int nodeIndex)
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
    }
}
