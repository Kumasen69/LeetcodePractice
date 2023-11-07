using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode501_FindModeInBinarySerchTree
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

        private Dictionary<int, int> keyValueCounter;

        private void countIntInTree(TreeNode root)
        {
            if(keyValueCounter.ContainsKey(root.val))
            {
                keyValueCounter[root.val]++;
            }
            else
            {
                keyValueCounter.Add(root.val, 1);
            }

            if(root.left != null)
            {
                countIntInTree(root.left);
            }
            if(root.right != null)
            {
                countIntInTree(root.right);
            }

        }

        public int[] FindMode(TreeNode root)
        {
            List<int> result = new List<int>();
            this.keyValueCounter = new Dictionary<int, int>();

            countIntInTree(root);
             this.keyValueCounter = this.keyValueCounter.OrderBy((x) => x.Value).ToDictionary(x => x.Key, x => x.Value);

            int maxValue = this.keyValueCounter.ElementAt(keyValueCounter.Count - 1).Value;

            
            for(int i = 1; i <= this.keyValueCounter.Count; i++ )
            {
                if (this.keyValueCounter.ElementAt(keyValueCounter.Count - i).Value == maxValue)
                    result.Add(this.keyValueCounter.ElementAt(keyValueCounter.Count - i).Key);
                else
                    break;
            }

            return result.ToArray();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution st = new Solution();

            TreeNode testTree = new TreeNode();
            testTree.val = 1;
            testTree.right = new TreeNode();
            testTree.right.val = 2;
            testTree.right.right = new TreeNode();
            testTree.right.right.val = 2;

            int[] result = st.FindMode(testTree);

            Console.WriteLine("OK");
        }
    }
}
