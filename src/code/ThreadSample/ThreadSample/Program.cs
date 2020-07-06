using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSample
{
#if _EX02
    class SideTask
    {
        private int count;

        public SideTask(int count)
        {
            this.count = count;
        }

        public void KeepAlive()
        {
            try
            {
                while (count > 0)
                {
                    Console.WriteLine($"{count--} left");
                    Thread.Sleep(10);
                }

                Console.WriteLine("Count : 0");
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine(e);
                Thread.ResetAbort();
            }
            finally
            {
                Console.WriteLine("Clearing resource...");
            }
        }
    }
#endif
#if _EX04
    class SideTask
    {
        private int count;

        public SideTask(int count)
        {
            this.count = count;
        }

        public void KeepAlive()
        {
            try
            {
                Console.WriteLine("Running thread isn't goona be interrupted");
                Thread.SpinWait(1000000000);

                while (count > 0)
                {
                    Console.WriteLine($"{count--} left");

                    Console.WriteLine("Entering into WaitJoinSleep State...");
                    Thread.Sleep(10);
                }

                Console.WriteLine("Count : 0");
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine(e);
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine(e);
                Thread.ResetAbort();
            }
            finally
            {
                Console.WriteLine("Clearing resource...");
            }
        }
    }
#endif
    class Counter
    {
        private const int LOOP_COUNT = 1000;
        private readonly object thisLock;
        private bool lockedCount = false;

        private int count;

        public int Count
        {
            get { return count; }
        }

        public Counter()
        {
            thisLock = new object();
            count = 0;
        }

        public void Increase()
        {
            int loopCount = LOOP_COUNT;
            while (loopCount-- > 0)
            {
                lock (thisLock)
                {
                    while (count > 0 || true == lockedCount)
                        Monitor.Wait(this.thisLock);

                    lockedCount = true;
                    count++;
                    lockedCount = false;

                    Monitor.Pulse(thisLock);
                }
                Console.WriteLine($"Increase.Count : {Count}");
            }
        }

        public void Decrease()
        {
            int loopCount = LOOP_COUNT;
            while (loopCount-- > 0)
            {
                lock (thisLock)
                {
                    while (count < 0 || true == lockedCount)
                        Monitor.Wait(this.thisLock);
                    
                    lockedCount = true;
                    count--;
                    lockedCount = false;

                    Monitor.Pulse(thisLock);
                }
                Console.WriteLine($"Decrease.Count : {Count}");
            }
        }
    }


    class Program
    {
#if _EX01
        static void DoSomeThing()
        {
            for (int i = 0; i < 5; ++i)
            {
                Console.WriteLine($"DoSomething : {i}");
                Thread.Sleep(10);
            }
        }
#endif
#if _EX03
        private static void PrintThreadState(ThreadState state)
        {
            Console.WriteLine($"{state, -16} : {(int)state}");
        }
#endif

        static void Main(string[] args)
        {
#if _EX01
            Thread t1 = new Thread(new ThreadStart(DoSomeThing));
            Console.WriteLine("String Thread..");
            t1.Start();

            for (int i = 0; i < 5; ++i)
            {
                Console.WriteLine($"Main : {i}");
                Thread.Sleep(10);
            }

            Console.WriteLine("Wating until thread stops...");
            t1.Join();

            Console.WriteLine("Finish");
#endif
#if _EX02
            SideTask task = new SideTask(100);
            Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
            t1.IsBackground = true;

            Console.WriteLine("Start thread");
            t1.Start();

            Thread.Sleep(100);

            Console.WriteLine("Aborting thread...");
            t1.Abort();

            Console.WriteLine("Finished");
#endif
#if _EX03
            PrintThreadState(ThreadState.Running);
            PrintThreadState(ThreadState.StopRequested);
            PrintThreadState(ThreadState.SuspendRequested);
            PrintThreadState(ThreadState.Background);
            PrintThreadState(ThreadState.Unstarted);
            PrintThreadState(ThreadState.Stopped);
            PrintThreadState(ThreadState.WaitSleepJoin);
            PrintThreadState(ThreadState.Suspended);
            PrintThreadState(ThreadState.AbortRequested);
            PrintThreadState(ThreadState.Aborted);
            PrintThreadState(ThreadState.Aborted | ThreadState.Stopped);  
#endif
#if _EX04
            SideTask task = new SideTask(100);
            Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
            t1.IsBackground = true;

            Console.WriteLine("Starting thread...");
            t1.Start();

            Thread.Sleep(100);

            Console.WriteLine("Interrupting thread...");
            t1.Interrupt();

            Console.WriteLine("Waiting until thread stops");
            t1.Join();

            Console.WriteLine("Finished");  
#endif
            Counter counter = new Counter();
            Thread incThread = new Thread(new ThreadStart(counter.Increase));
            Thread decThread = new Thread(new ThreadStart(counter.Decrease));

            incThread.Start();
            decThread.Start();

            incThread.Join();
            decThread.Join();

            Console.WriteLine(counter.Count);
        }
    }
}
