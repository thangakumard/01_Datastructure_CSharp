namespace DatastructureMSTest.Algorithms.LinkedList
{

    [TestClass]
    public class LRUCacheTestClass
    {
        [TestMethod]
        public void LRUTest()
        {
            LRUCache Cache = new LRUCache(2);
            Cache.Put(1, 1);
            //Cache.Put(2, 2);
            Assert.AreEqual(1, Cache.Get(1));
        }
    }
    public class LRUCache
    {
        class Node
        {
            public int Key { get; set; }
            public int Value { get; set; }

            public Node Prev { get; set; }
            public Node Next { get; set; }

            public Node(int k, int v)
            {
                Key = k;
                Value = v;
            }

            public Node()
            {
                Key = 0; Value = 0;
            }
        }

        readonly int Capacity;
        Node Head, Tail;
        Dictionary<int, Node> Cache = new Dictionary<int, Node>();

        public LRUCache(int capacity)
        {
            Capacity = capacity;
            Head = new Node(0, 0);
            Tail = new Node(0, 0);
            Head.Next = Tail;
            Tail.Prev = Head;
        }

        public int Get(int key)
        {
            if (Cache.ContainsKey(key))
            {
                Node currentNode = Cache[key];
                Update(currentNode);
                return currentNode.Value;
            }
            return -1;
        }

        public void Put(int key, int value)
        {
            Node CurrentNode = Cache.GetValueOrDefault(key, null);
            if(CurrentNode == null)
            {
                Node node = new Node(key, value);
                Cache.Add(key, node);
                Add(node);
            }
            else
            {
                Update(CurrentNode);
                CurrentNode.Value = value;
            }

            if (Cache.Count > Capacity) { 
                Node Node_To_Delete = Tail.Prev;
                Cache.Remove(Node_To_Delete.Key);
                Remove(Node_To_Delete);
            }
        }

        private void Add(Node CurrentNode)
        {
            Node After = Head.Next;

            Head.Next = CurrentNode;
            CurrentNode.Next = After;

            After.Prev = CurrentNode;
            CurrentNode.Prev = Head;
        }

        private void Remove(Node CurrentNode)
        {
            Node Prev = CurrentNode.Prev;
            Node Next = CurrentNode.Next;

            Prev.Next = Next;
            Next.Prev = Prev;
        }

        private void Update(Node CurrentNode)
        {
            Remove(CurrentNode);
            Add(CurrentNode);
        }
    }
}
