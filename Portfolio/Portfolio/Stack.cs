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
            
            {
                Console.WriteLine(obj);
            }
            
            return obj;
        }
        public void clear()
        {
            list.Clear();
            index = -1;
        }
        public object Peek()
        {
            return list[index];
        }


    }   
}
