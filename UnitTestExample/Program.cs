using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExample
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static long Hashing(String s)
        {
            long h = 7;
            var letters = "acdegilmnoprstuw";
            var index = 0;
            long inc = 0;

            for (int i = 0; i < s.Length; i++)
            {
                inc = h * 37;
                index = letters.IndexOf(s[i]);
                h = inc + index;
            }


            return h;
        }
    }
}
