using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeSumBST
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public int RangeSumBST(TreeNode root, int low, int high)
        {
            if (root == null)
                return 0;
            int curr = 0;
            if (root.val >= low && root.val <= high)
                curr = root.val;
            int leftSum = RangeSumBST(root.left, low, high);
            int rightSum = RangeSumBST(root.right, low, high);
            return curr + leftSum + rightSum;
        }
    }
}
