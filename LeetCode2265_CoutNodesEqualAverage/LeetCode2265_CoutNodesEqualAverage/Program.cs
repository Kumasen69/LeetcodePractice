using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode2265_CoutNodesEqualAverage
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

        //int {chileNode Total , chileNode Num , AverageCount}
        public int[] GetNodeAverage(TreeNode root)
        {
            if (root.left == null && root.right == null)
            {
                int[] result = { root.val, 1, 1 };
                return result;
            }

            if (root.right != null && root.left != null)
            {
                int[] rightResult = GetNodeAverage(root.right);
                int[] leftResult = GetNodeAverage(root.left);

                int[] result = new int[3];
                result[0] = root.val + rightResult[0] + leftResult[0];
                result[1] = rightResult[1] + leftResult[1] + 1;
                result[2] = rightResult[2] + leftResult[2];
                if (result[0] / result[1] == root.val)
                {
                    result[2] += 1;
                }
                return result;
            }
            else if (root.right != null)
            {
                int[] rightResult = GetNodeAverage(root.right);

                int[] result = new int[3];
                result[0] = root.val + rightResult[0];
                result[1] = rightResult[1] + 1;
                result[2] = rightResult[2];
                if (result[0] / result[1] == root.val)
                {
                    result[2] += 1;
                }
                return result;
            }
            else
            {
                int[] leftResult = GetNodeAverage(root.left);

                int[] result = new int[3];
                result[0] = root.val + leftResult[0];
                result[1] = leftResult[1] + 1;
                result[2] = leftResult[2];
                if (result[0] / result[1] == root.val)
                {
                    result[2] += 1;
                }
                return result;
            }
        }

   

        public int AverageOfSubtree(TreeNode root)
        {
            int[] result = GetNodeAverage(root);
            return result[2];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
