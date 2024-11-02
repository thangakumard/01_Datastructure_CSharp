using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithms.Tree.Traversal.BFS
{
    [TestClass]
    public class LevelOrderTraversal
    {
        [TestMethod]
        public void PrintLevelOrderTraversal(){
            TreeNode root = new TreeNode(40);
            root.Left = new TreeNode(30);
            root.Right = new TreeNode(50);
            root.Left.Left = new TreeNode(25);
            root.Left.Right = new TreeNode(35);
            List<int> result = GetLevelOrderTraversal(root);
            foreach(int x in result){
                Console.WriteLine(x);
            }
        }

        private List<int> GetLevelOrderTraversal(TreeNode root){
            List<int> result = new List<int>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            TreeNode currentNode;
            queue.Enqueue(root);
            while(queue.Count > 0){
                int size = queue.Count;
                for(int i=0; i<size; i++){
                    currentNode = queue.Dequeue();
                    result.Add(currentNode.Val);
                    if(currentNode.Left != null)
                        queue.Enqueue(currentNode.Left);
                    if(currentNode.Right != null)
                        queue.Enqueue(currentNode.Right);
                }
            }
            return result;
        }
    }
}