using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SameTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;
            if (p == null || q == null)
                return false;
            if (p.val != q.val)
                return false;
            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }
}
