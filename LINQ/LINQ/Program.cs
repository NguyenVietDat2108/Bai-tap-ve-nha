using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    
    class Program
    {
        public static void Display<T>(IEnumerable<T> a)
    {
            foreach(T s in a)
            {
                Console.WriteLine(s);
            }
    }
        static void Main(string[] args)
        {
            //Query Expression
            string[] names = { "Hanna","Jim","Pearl","Mel","Jill","Peter","Karl","Abby","Benjamin" };
            IEnumerable<string> words = from word in names
                                        where word.EndsWith("l")
                                        orderby word descending
                                        select word;
            Display<string>(words);

            int[] scores = { 2, 39,490, 600, 90 };
            IEnumerable<int> highScoresQuery =
                from score in scores
                where score > 80
                orderby score descending
                select score;
            Display<int>(scores);

            IEnumerable<string> highScoresQuery2 =
                from score in scores
                where score > 80
                orderby score descending
                select $"The score is {score}";
            Display<string>(highScoresQuery2);

            int highScoreCount = (
                from score in scores
                where score > 80
                select score
                ).Count();
            Console.WriteLine("Count:" + highScoreCount);

            //Lambda and LINQ methods
            int[] numbers = { 4, 5, 8, 3, 1, 67, 89, 45, 34, 24, 56, 92 };
            var odds = numbers.Where(x => x % 2 != 0).OrderByDescending(n => n);
            Display<int>(odds);
        }
    }
}
