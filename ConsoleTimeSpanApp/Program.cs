using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTimeSpanApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

             int consultationTime = 30;
            TimeSpan beginWorkingTime = new TimeSpan(8, 0, 0);
            TimeSpan endWorkingTime = new TimeSpan(18, 0, 0);
            TimeSpan interval;
            interval = new TimeSpan(0, consultationTime, 0);
            while (beginWorkingTime != endWorkingTime)
            {
                Console.WriteLine(beginWorkingTime);
                beginWorkingTime = beginWorkingTime + interval;
                
            }
            Console.ReadKey();
        }
    }
}
