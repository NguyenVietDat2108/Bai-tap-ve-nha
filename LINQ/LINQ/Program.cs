using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public static class ExtendString
    {
        public static int CountWord(this string str)
        {
            return str.Split(new char[] { ' ' }).Length;
        }

        class ComplexTask
        {
            public Task<int> AnalyzeData()
            {
                Task<int> task = new Task<int>(delegate ()
                {
                    return new Random().Next(1, 1000);
                });
                task.Start();
                return task;
            }
        }
        class Program
    {
            static async void PerformComputationAsync()
            {
                Console.WriteLine("Entering asyncronous method");
                int result = await new ComplexTask().AnalyzeData();
                Console.WriteLine(result.ToString());
            }

            public static void Display<T>(IEnumerable<T> a)
        {
            foreach (T s in a)
            {
                Console.WriteLine(s);
            }
        }
        static void Main(string[] args)
        {
            //Query Expression
            string[] names = { "Hanna", "Jim", "Pearl", "Mel", "Jill", "Peter", "Karl", "Abby", "Benjamin" };
            IEnumerable<string> words = from word in names
                                        where word.EndsWith("l")
                                        orderby word descending
                                        select word;
            Display<string>(words);

            int[] scores = { 2, 39, 490, 600, 90 };
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
            var odds = numbers.Where(y => y % 2 != 0).OrderByDescending(n => n);
            Display<int>(odds);

                //Extension method
                string st = "Everything you can imagine is real";
                Console.WriteLine("Total words:" + st.CountWord());

                //Nullable type
                Nullable<int> x = null;
                double? m = null;
                x = 10;
                if (x.HasValue)
                    Console.WriteLine("x=" + x);
                else
                    Console.WriteLine("x is null");
                m = m ?? 0;
                Console.WriteLine("m=" + m);
                
                //Asynchronous method
                PerformComputationAsync();
                Console.WriteLine("Main thread executing");
                Console.ReadLine();
            }
        
    }
    }
}
