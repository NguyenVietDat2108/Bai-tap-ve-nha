using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ex_10._12
{
    class Program
    {
        static async void PerformComplexTaskAsync()
        {
            Console.WriteLine("Chuan bi goi phuong thuc bat dong bo");
            int result = await new ComplexTask().AnalyzeData();
            Console.WriteLine(result.ToString());
        }
        static void Main(string[] args)
        {
            PerformComplexTaskAsync();
            Console.WriteLine("Thread Main executing...");
            Console.ReadLine();
        }
    }
    class ComplexTask
    {
        public Task<int> AnalyzeData()
        {
            Task<int> task = new Task<int>(GetResult);
            task.Start();
            return task;
        }

        public int GetResult()
        {
            Thread.Sleep(5000);
            return new Random().Next(1, 1000);
        }
    }
}
