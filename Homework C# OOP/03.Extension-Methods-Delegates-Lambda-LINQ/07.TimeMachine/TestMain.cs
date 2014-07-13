using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07.TimeMachine
{
    class TestMain
    {
        static void Main(string[] args)
        {
            Timer.Start(() => Console.WriteLine("HA!"), 1);

            Thread.Sleep(7000);
        }
    }
}

//Using delegates write a class Timer that has can execute certain
//method at each t seconds.