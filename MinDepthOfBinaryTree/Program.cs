using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinDepthOfBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static int MinDepthOfBinaryTree(TreeNode root)
        {
            if (root == null)
                return 0;

            var leftMinDepth = MinDepthOfBinaryTree(root.left);
            var rightMinDepth = MinDepthOfBinaryTree(root.right);

            if (leftMinDepth == 0 || rightMinDepth == 0)
            {
                return Math.Max(leftMinDepth, rightMinDepth) + 1;
            }

            return Math.Min(leftMinDepth, rightMinDepth) + 1;
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}
