using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode5_LongestPalindromic
{
    public class Solution
    {
        private bool isPalindrome(string s)
        {
            for(int i = 0; i< s.Length; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                    return false;
            }
            return true;
        }
        public string LongestPalindrome(string s)
        {
            //List<char> charList = new List<char>();

            //for (int i = 0; i < 10; i++)
            //    charList.Add(i.ToString()[0]);
            //for (int i = 0; i<26; i++)
            //{
            //    charList.Add((char)('a' + i));
            //    charList.Add((char)('A' + i));
            //}    

            string temp = "";
            int length = s.Length;

            for (int i = length; i > 0; i--)
            {
                for (int startIndex = 0; startIndex + i <= length; startIndex++)
                {
                    temp = s.Substring(startIndex, i);
                    if (isPalindrome(temp))
                        return temp;
                }
            }
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution sl = new Solution();
            Console.WriteLine(sl.LongestPalindrome("anugnxshgonmqydttcvmtsoaprxnhpmpovdolbidqiyqubirkvhwppcdyeouvgedccipsvnobrccbndzjdbgxkzdbcjsjjovnhpnbkurxqfupiprpbiwqdnwaqvjbqoaqzkqgdxkfczdkznqxvupdmnyiidqpnbvgjraszbvvztpapxmomnghfaywkzlrupvjpcvascgvstqmvuveiiixjmdofdwyvhgkydrnfuojhzulhobyhtsxmcovwmamjwljioevhafdlpjpmqstguqhrhvsdvinphejfbdvrvabthpyyphyqharjvzriosrdnwmaxtgriivdqlmugtagvsoylqfwhjpmjxcysfujdvcqovxabjdbvyvembfpahvyoybdhweikcgnzrdqlzusgoobysfmlzifwjzlazuepimhbgkrfimmemhayxeqxynewcnynmgyjcwrpqnayvxoebgyjusppfpsfeonfwnbsdonucaipoafavmlrrlplnnbsaghbawooabsjndqnvruuwvllpvvhuepmqtprgktnwxmflmmbifbbsfthbeafseqrgwnwjxkkcqgbucwusjdipxuekanzwimuizqynaxrvicyzjhulqjshtsqswehnozehmbsdmacciflcgsrlyhjukpvosptmsjfteoimtewkrivdllqiotvtrubgkfcacvgqzxjmhmmqlikrtfrurltgtcreafcgisjpvasiwmhcofqkcteudgjoqqmtucnwcocsoiqtfuoazxdayricnmwcg"));
            Console.ReadKey();
        }
    }
}
