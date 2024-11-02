namespace Algorithms.Tree.BinarySearchTree
{
    [TestClass]
    public class BST01_LCA_LowestCommonAncestor
    {
        [TestMethod]
        public void BST_LCA(){
            TreeNode root = new TreeNode(40);
            root.Left = new TreeNode(30);
            root.Right = new TreeNode(50);
            root.Left.Left = new TreeNode(25);
            root.Left.Right = new TreeNode(35);
            root.Right.Left = new TreeNode(45);
            Console.WriteLine("getLCA(root, 25, 45) :" + getLCA(root, 25, 45));
        }

        private int getLCA(TreeNode root, int n1, int n2){
            if(root == null) return -1;

            if(root.Val < Math.Min(n1, n2)){
               return getLCA(root.Right, n1,n2);
            }else if(root.Val > Math.Max(n1, n2)){
                return getLCA(root.Left, n1,n2);
            }

            return root.Val;
        }
    }
}