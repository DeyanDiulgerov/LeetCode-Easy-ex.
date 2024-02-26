using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInABinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null)
                return null;
            if (root.val == val)
                return root;
            if (root.val < val)
                return SearchBST(root.right, val);

            return SearchBST(root.left, val);
        }
    }
}
