using System.Collections.Generic;

namespace OS_Regedit
{
    public class Node
    {
        public int Id { get; set; }
        public List<Key> Keys { get; set; }
        public Node Parent { get; set; }
        public List<Node> Childs { get; set; }

        public Node()
        {
            Id = -1;
            Keys = new List<Key>();
            Childs = new List<Node>();
        }

        public Node(int id, Node parent)
        {
            Id = id;
            Keys = new List<Key>();
            Parent = parent;
        }
    }
}
