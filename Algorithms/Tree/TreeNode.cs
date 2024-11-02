
namespace Algorithms.Tree
{
    public class TreeNode(int val)
    {
        public int Val { get; set; } = val;
        public TreeNode? Left { get; set; }
        public TreeNode? Right { get; set; }
    }
}