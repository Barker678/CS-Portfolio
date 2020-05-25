namespace Portfolio
{
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
}
