using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace ex_10._11
{
    class Program
    {
        static void Main(string[] args)
        {
            var results = new double[100_000_000];
            var usage = new ConcurrentDictionary<int, int>();

            Parallel.For(0, results.Length, i =>
            {
                results[i] = Factorial(i % 20 + 1);
                usage.AddOrUpdate(Environment.CurrentManagedThreadId, 1, (_, count) => count + 1);
            });

            var values = Enumerable.Range(0, results.Length);
            var linqResults = (from val in values.AsParallel() select Count(Factorial(val % 20 + 1))).Average();

            Console.WriteLine(results.AsParallel().Average());

            Console.WriteLine($"{usage.Count} threads used:");

            foreach (var pair in usage)
                Console.WriteLine($"Thread {pair.Key} used {pair.Value} times.");

            double Factorial(int n)
            {
                return Enumerable.Range(1, n).Aggregate((a, b) => a * b);
            }
            
            T Count<T>(T a)
        {   
            usage.AddOrUpdate(Environment.CurrentManagedThreadId, 1, (_, count) => count + 1);

            return a;
        }

        }
        
    }
}
