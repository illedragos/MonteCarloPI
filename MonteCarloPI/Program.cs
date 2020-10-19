using System;
using System.Diagnostics;

namespace MonteCarloPI
{

    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            double R = 1;
            double nr = 0;  
            for (int i = 0; i < 1000000; i++)
            {
                double x = random.NextDouble();
                double y = random.NextDouble();
                double dist = x * x + y * y;
                Console.WriteLine(dist);
                if (dist <= R)
                {
                    nr++;
                }
            }
            double P = nr / 1000000;
            Console.WriteLine("PI ="+(4 * P));


            //////////////////////////////////////////////////
            TimeSpan ts = stopWatch.Elapsed;
            stopWatch.Stop();
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
            //////////////////////////////////////////////////////////

      
        }

    }
}
