using System.Threading;

namespace TestTasks.Models
{
    public class Node
    {
        private int _value;

        private int _Id;

        public int Id { get => _Id; set => _Id = value; }
        public int value { get => _value; set => _value = value; }
        public Node? next;
        public Node? prev;

        public Node(int value, int Id)
        {
            _value = value;  
            next = null;
            prev = null;
            _Id = Id;
        }
    }
}
