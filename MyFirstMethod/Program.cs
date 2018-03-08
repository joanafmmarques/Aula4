using System;

namespace MyAula04
{
   /// <summary>
   /// Class Aula4
   /// </summary>
    class MyClass
    {
        /// <summary>
        /// Method that prints on the screen numbers from n1 to n2
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        static void Main(string[] args)
        {
            
            CountToN(3,10);
            
        }

        /// <summary>
        /// Method that counts from n1 to n2
        /// </summary>
        /// <param name="n1">inicial number to count from</param>
        /// <param name="n2">final number to count to</param>
        static void CountToN(int n1, int n2)
        {
            for (int i = n1; i <= n2; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
