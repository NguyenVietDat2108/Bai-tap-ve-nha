using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_defined_generic_delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> cw = CountWord;
            Console.WriteLine(cw("I love VietNam"));
        }
        public static int CountWord(string str)
        {
            return str.Split(new char[] { ' ' }).Length;
        }
        // public String[] Split(params char[] separator);
        // Summary:
        //     Splits a string into substrings that are based on the characters in an array.
        //
        // Parameters:
        //   separator:
        //     A character array that delimits the substrings in this string, an empty array
        //     that contains no delimiters, or null.
        //
        // Returns:
        //     An array whose elements contain the substrings from this instance that are delimited
        //     by one or more characters in separator. For more information, see the Remarks
        //     section.
    }
}
