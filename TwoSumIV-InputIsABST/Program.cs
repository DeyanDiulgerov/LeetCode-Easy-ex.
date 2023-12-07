using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSumIV_InputIsABST
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        HashSet<int> seen = new HashSet<int>();
        public bool FindTarget(TreeNode root, int k)
        {
            if (root is null)
                return false;
            if (seen.Contains(k - root.val))
                return true;
            seen.Add(root.val);

            return FindTarget(root.left, k)
                || FindTarget(root.right, k);
        }
    }
}
