using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode2236_RootEqulaSum
{

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

    public class Solution
    {
        public bool CheckTree(TreeNode root)
        {
            return root.val == (root.left.val + root.right.val);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
