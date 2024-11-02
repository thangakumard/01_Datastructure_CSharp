using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Algorithms.Tree.Traversal.DFS
{
    [TestClass]
    public class PostorderIterative
    {
        [TestMethod]
        public void PrintPostOrder(){
            TreeNode root = new TreeNode(40);
            root.Left = new TreeNode(30);
            root.Right = new TreeNode(50);
            root.Left.Left = new TreeNode(25);
            root.Left.Right = new TreeNode(35);
            List<int> result = PostorderTraversal(root);

            foreach(int x in result){
                 Console.WriteLine(x); //Left Right Root
            }
        }

         private List<int> PostorderTraversal(TreeNode root){
            List<int> result = new List<int>();
            if(root == null) return result;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode currentNode;

            while(root != null || stack.Count > 0){
                if(root != null){
                    stack.Push(root);
                    root = root.Left;
                }else{
                    if(stack.Count == 0) break;

                    TreeNode? temp = stack.Peek().Right;
                    if(temp == null){
                        temp = stack.Pop();
                        result.Add(temp.Val);
                        while(stack.Count > 0 && stack.Peek().Right == temp){
                            temp = stack.Pop();
                            result.Add(temp.Val);
                        }

                    }else{
                        root = temp;
                    }
                }
            }
            return result;
         }
    }
}