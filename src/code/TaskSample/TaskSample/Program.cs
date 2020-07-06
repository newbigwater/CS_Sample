using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskSample
{
    class Program
    {
        static bool IsPrime(long number)
        {
            if (number < 2)
                return false;

            if (number % 2 == 0 && number != 2)
                return false;

            for (long i = 2; i < number; ++i)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
#if _EX01
            string srcFile = "d:\\a.txt";
            Console.WriteLine($"{srcFile}");

            Action<Object> FileCopyAction = (Object state) =>
            {
                string[] paths = (string[]) state;
                File.Copy(paths[0], paths[1]);

                Console.WriteLine(
                        $"Task ID : {Task.CurrentId}, " +
                        $"ThreadID:{Thread.CurrentThread.ManagedThreadId}, " +
                        $"{paths[0]} was copied to {paths[1]}"
                    );
            };
            
            Task t1 = new Task(
                FileCopyAction, 
                new string[] {srcFile, srcFile+".copy1"}
                );

            Task t2 = Task.Run(() =>
            {
                FileCopyAction(new string[] {srcFile, srcFile + ".copy2"});
            });

            t1.Start();

            Task t3 = new Task(
                FileCopyAction, 
                new string[] {srcFile, srcFile+".copy3"}
                );

            t3.RunSynchronously();

            t1.Wait();
            t2.Wait();
            t3.Wait();
#endif
            long from = 1; //Convert.ToInt64(args[0]);
            long to = 100; //Convert.ToInt64(args[1]);
            int taskCount = 3; //Convert.ToInt32(args[2]);

            Func<Object, List<long>> FindPrimeFunc =
                (objRange) =>
                {
                    long[] range = (long[]) objRange;
                    List<long> found = new List<long>();

                    for (long i = range[0]; i < range[1]; ++i)
                    {
                        if (IsPrime(i))
                            found.Add(i);
                    }

                    return found;
                };

            Task<List<long>>[]tasks = new Task<List<long>>[taskCount];
            long currentFrom = from;
            long currentTo = to / tasks.Length;
            for (int i = 0; i < tasks.Length; ++i)
            {
                Console.WriteLine($"Task{i} : {currentFrom} ~ {currentTo}");

                tasks[i] = new Task<List<long>>(FindPrimeFunc, new long[] {currentFrom, currentTo});
                currentFrom = currentTo + 1;

                if (i >= tasks.Length - 2)
                    currentTo = to;
                else
                    currentTo = currentTo + (to / tasks.Length);
            }

            Console.WriteLine("Please press enter to start...");
            Console.ReadLine();
            Console.WriteLine("Started");

            DateTime startTime = DateTime.Now;

            foreach (Task<List<long>> task in tasks)
                task.Start();

            List<long> total = new List<long>();

            foreach (Task<List<long>> task in tasks)
            { 
                task.Wait();
                total.AddRange(task.Result.ToArray());
            }

            DateTime endTime = DateTime.Now;

            TimeSpan ellapsed = endTime - startTime;

            Console.WriteLine($"Prime number count between {from} and {to} : {total.Count}");
            Console.WriteLine($"Ellapsed time : {ellapsed}");
        }
    }
}
