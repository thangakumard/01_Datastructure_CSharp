

namespace Algorithms.Tree.Traversal.DFS
{
    [TestClass]
    public class PreorderIterative
    {
        [TestMethod]
        public void PrintInOrder(){
            TreeNode root = new TreeNode(40);
            root.Left = new TreeNode(30);
            root.Right = new TreeNode(50);
            root.Left.Left = new TreeNode(25);
            root.Left.Right = new TreeNode(35);
            PreorderTraversal(root);
        }

        private void PreorderTraversal(TreeNode root){
            if(root == null) return;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            TreeNode currentNode;

            while(stack.Count > 0){
                currentNode = stack.Pop();
                Console.WriteLine(currentNode.Val);
                if(currentNode.Right != null){
                    stack.Push(currentNode.Right);
                }
                if(currentNode.Left != null){
                    stack.Push(currentNode.Left);
                }
            }
        }
    }
}