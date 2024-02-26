using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RootEqualSumOfChildren
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        public bool CheckTree(TreeNode root)
        {
            return root.val == root.left.val + root.right.val;
        }
    }
}
