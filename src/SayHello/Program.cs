﻿using System;
using System.Threading;

namespace SayHello
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hello World!");
                Thread.Sleep(TimeSpan.FromSeconds(3));
            }
        }
    }
}
