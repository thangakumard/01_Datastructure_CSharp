using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithms.Tree.Traversal
{
    [TestClass]
    public class VertialOrderTraversal
    {
        [TestMethod]
        public void PrintVertialOrderTraversal(){
            TreeNode root = new TreeNode(40);
            root.Left = new TreeNode(30);
            root.Right = new TreeNode(50);
            root.Left.Left = new TreeNode(25);
            root.Left.Right = new TreeNode(35);
            root.Right.Left = new TreeNode(45);
            GetVertialOrderTraversal(root);
        }

        private void GetVertialOrderTraversal(TreeNode root){
            Dictionary<int,List<int>> dicVertical = new Dictionary<int, List<int>>();
            Queue<TreeNode> nodeQueue = new Queue<TreeNode>();
            Queue<int> indexQueue = new Queue<int>();
            nodeQueue.Enqueue(root);
            indexQueue.Enqueue(0);

            int index = 0, minIndex =0, maxIndex = 0;
            TreeNode currentNode;

            while(nodeQueue.Count > 0){
                currentNode = nodeQueue.Dequeue();
                index = indexQueue.Dequeue();

                if(!dicVertical.ContainsKey(index)){
                    dicVertical.Add(index, new List<int>());
                }
                dicVertical[index].Add(currentNode.Val);

                minIndex = Math.Min(minIndex, index);
                maxIndex = Math.Max(maxIndex, index);

                if(currentNode.Left != null){
                    nodeQueue.Enqueue(currentNode.Left);
                    indexQueue.Enqueue(index-1);
                }
                if(currentNode.Right != null){
                    nodeQueue.Enqueue(currentNode.Right);
                    indexQueue.Enqueue(index+1);
                }
            }

            List<int> result = new List<int>();
            
            for(int i=minIndex; i < maxIndex+1; i++){
                 result = dicVertical[i];

                 foreach(int x in result){
                    Console.WriteLine(x);
                 }
            }
        }
    }
}