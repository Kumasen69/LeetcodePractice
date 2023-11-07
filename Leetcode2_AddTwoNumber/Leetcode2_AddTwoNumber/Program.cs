using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode2_AddTwoNumber
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode();
            ListNode now = result;
            
            int next = 0;

            while(l1 !=null || l2 != null || next != 0)
            {
                if(l1 !=null && l2 != null)
                {
                    now.val = l1.val + l2.val + next;
                    next = now.val / 10;
                    if (now.val >= 10)
                    {
                        now.val %= 10;
                    }
                    if(l1.next != null || l2.next != null || next != 0)
                    {
                        now.next = new ListNode();
                        now = now.next;
                    }
                    l1 = l1.next;
                    l2 = l2.next;
                }
                else if(l1 != null)
                {
                    now.val = l1.val + next;
                    next = now.val / 10;
                    if(now.val >= 10)
                    {
                        now.val %= 10;
                    }

                    if (l1.next != null || next != 0)
                    {
                        now.next = new ListNode();
                        now = now.next;
                    }
                    l1 = l1.next;
                }
                else if(l2 != null)
                {
                    now.val = l2.val + next;
                    next = now.val / 10;
                    if (now.val >= 10)
                    {
                        now.val %= 10;
                    }

                    if (l2.next != null || next != 0)
                    {
                        now.next = new ListNode();
                        now = now.next;
                    }
                    l2 = l2.next;
                }
                else if(next != 0)
                {
                    now.val = next;
                    next = 0;
                }
            }

            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
