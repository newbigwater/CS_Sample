using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSample
{
    class EventProducer
    {
        public void Raise()
        {
            var handler = EventRaised;
            if (handler != null)
                handler(this, EventArgs.Empty);
        }

        public event EventHandler EventRaised;
    }

    class Counter
    {
        long count = 0;
        EventProducer producer = new EventProducer();
        EventHandler savedEvent;

        public Counter()
        {
            savedEvent = CountEvent;
        }

        private void CountEvent(object sender, EventArgs e)
        {
            count++;
        }

        public void Count()
        {
            producer.EventRaised += CountEvent;
            producer.Raise();
            producer.EventRaised -= CountEvent;
        }

        public void CountWithNew()
        {
            producer.EventRaised += new EventHandler(CountEvent);
            producer.Raise();
            producer.EventRaised -= new EventHandler(CountEvent);
        }
        public void CountSaved()
        {
            producer.EventRaised += savedEvent;
            producer.Raise();
            producer.EventRaised -= savedEvent;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            const int TestIterations = 10000000;

            TimeSpan countTime = TestCounter(c => c.Count());
            Console.WriteLine("Count: {0}", countTime);

            TimeSpan countWithNewTime = TestCounter(c => c.CountWithNew());
            Console.WriteLine("CountWithNew: {0}", countWithNewTime);

            TimeSpan countSavedTime = TestCounter(c => c.CountSaved());
            Console.WriteLine("CountSaved: {0}", countSavedTime);

            Console.ReadLine();
        }

        static TimeSpan TestCounter(Action<Counter> action)
        {
            var counter = new Counter();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 10000000; i++)
                action(counter);
            sw.Stop();
            return sw.Elapsed;
        }
    }
}
