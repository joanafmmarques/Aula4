﻿using System;

namespace MyAula04
{
    class MyClass
    {
        static void Main(string[] args)
        {
            CountTo10();
            CountTo10();
            
        }

        static void CountTo10()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
