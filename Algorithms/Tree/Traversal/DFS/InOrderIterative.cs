

using Microsoft.VisualStudio.TestPlatform.MSTest.TestAdapter.ObjectModel;

namespace Algorithms.Tree.Traversal.DFS
{
    [TestClass]
    public class InOrderIterative
    {
        [TestMethod]
        public void PrintInOrder(){
            TreeNode root = new TreeNode(40);
            root.Left = new TreeNode(30);
            root.Right = new TreeNode(50);
            root.Left.Left = new TreeNode(25);
            root.Left.Right = new TreeNode(35);
            InOrderTraversal(root);
        }

        private void InOrderTraversal(TreeNode root){
            Stack<TreeNode> stack = new Stack<TreeNode>();

            while(true){
                if(root != null){
                    stack.Push(root);
                    root = root.Left;
                }else{
                    if(stack.Count == 0) break;
                    TreeNode temp = stack.Pop();
                    Console.WriteLine(temp.Val);
                    
                    root = temp.Right;
                }
            }
        }
    }
}