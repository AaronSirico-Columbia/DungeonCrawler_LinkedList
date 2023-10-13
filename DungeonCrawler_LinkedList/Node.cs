//Credit: https://www.youtube.com/watch?v=GcC5kW9tyOQ&t=633s

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLinkedLists
{
    public class Node
    {
        private int _data;
        public int Data
        {
            get { return _data; }
            set { _data = value; }
        }

        private Node _next;
        public Node Next
        {
            get { return _next; }
            set { _next = value; }
        }

        private Node _previous;
        public Node Previous
        {
            get { return _previous; }
            set { _previous = value; }

        }

        public Node(int data)
        {
            Data = data;
        }

    }
}