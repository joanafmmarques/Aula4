using System;

namespace MyAula04
{
   /// <summary>
   /// Class Aula4
   /// </summary>
    class MyClass
    {
        /// <summary>
        /// Method that prints on the screen numbers from 1 to 10
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        static void Main(string[] args)
        {
            
            CountTo10();
            
        }
        /// <summary>
        /// Method that uses CountToN() to count to 10
        /// </summary>
        static void CountTo10()
        {
                CountToN(10);
        }

        /// <summary>
        /// Method that counts to n
        /// </summary>
        /// <param name="n">Var int that will make the cicle for print numbers
        /// from 1 to n</param>
        static void CountToN(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
