using System.Collections;
using System.Collections.Generic;

namespace TestTasks.Models
{
    public class List : IEnumerable<Node>
    {
        private Node _head;
        private Node _tail;
        private int count = 1;

        public Node head { get { return _head; } }

        public Node tail { get { return _tail; } }

        public List()
        {
            Node newNode = new Node(0, 0)
            {
                Id = 0
            };
            _head = newNode;
            _tail = newNode;
        }

        public void AddElement()
        {
            Node newNode = new(0, count)
            {
                next = null,
                prev = tail
            };

            Node tempNode = _head;

            while (tempNode.next != null)
                tempNode = tempNode.next;

            tempNode.next = newNode;
            _tail = newNode;
            count++;
        }

        public void DeleteElementById(int Id)
        {
            Node tempNode = _head;

            if (tempNode.next != null && tempNode.Id == Id)
            {
                tempNode.prev = null;
                _head = tempNode.next;
            }

            while (tempNode.next != null && tempNode.Id != Id)
                tempNode = tempNode.next;

            if (tempNode.next == null && tempNode.Id == Id && tempNode.prev != null)
            {
                tempNode.prev.next = null;
                _tail = tempNode.prev;
            }
            else if (tempNode.next != null && tempNode.prev != null)
            {
                tempNode.prev.next = tempNode.next;
                tempNode.next.prev = tempNode.prev;
            }
            AddId();
            count--;
        }

        public int GetCount() { return count; }

        public int GetValueById(int Id)
        {
            Node tempNode = _head;
            while (tempNode.next != null && tempNode.Id != Id)
                tempNode = tempNode.next;
            return tempNode.value;
        }

        public Node GetNodeById(int Id)
        {
            Node tempNode = _head;
            while (tempNode.next != null && tempNode.Id != Id)
                tempNode = tempNode.next;
            return tempNode;
        }

        public void SwapNodes(Node nodeOne, Node nodeTwo)
        {
            (nodeTwo.value, nodeOne.value) = (nodeOne.value, nodeTwo.value);
        }

        public string ListToString()
        {
            string str = "";
            Node tempNode = _head;

            while (tempNode != null)
            {
                str += tempNode.value.ToString() + ' ';
                tempNode = tempNode.next;
            }

            return str;
        }

        private void AddId()
        {
            Node tempNode = _head;
            int id = 0;

            while (tempNode != null)
            {
                tempNode.Id = id;
                tempNode = tempNode.next;
                id++;
            }
        }

        public IEnumerator<Node> GetEnumerator()
        {
            Node current = _head;
            while (current != null)
            {
                yield return current;
                current = current.next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();

        }
    }
}
