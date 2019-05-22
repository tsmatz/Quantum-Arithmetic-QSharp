using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.QSharpBasicArithmetics
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                int N = 3;

                // Modulus Addition
                for (int a = 3, b = 3; a <= 7; a++)
                {
                    Console.WriteLine("{0} + {1} is {2} (mod {3})",
                        a,
                        b,
                        TestModularAdd.Run(qsim, a, b, N).Result,
                        Math.Pow(2, N));
                }
                for (int a = 7, b = 4; b <= 7; b++)
                {
                    Console.WriteLine("{0} + {1} is {2} (mod {3})",
                        a,
                        b,
                        TestModularAdd.Run(qsim, a, b, N).Result,
                        Math.Pow(2, N));
                }

                // Modulus Subtraction
                for (int a = 3, b = 5; a <= 7; a++)
                {
                    Console.WriteLine("{0} - {1} is {2} (mod {3})",
                        b,
                        a,
                        TestModularSub.Run(qsim, a, b, N).Result,
                        Math.Pow(2, N));
                }

                // Modulus Addition by Classical Numeric
                for (int a = 3, b = 3; a <= 7; a++)
                {
                    Console.WriteLine("{0} + {1} is {2} (mod {3})",
                        a,
                        b,
                        TestModularAddByNumber.Run(qsim, a, b, N).Result,
                        Math.Pow(2, N));
                }
                for (int a = 7, b = 4; b <= 7; b++)
                {
                    Console.WriteLine("{0} + {1} is {2} (mod {3})",
                        a,
                        b,
                        TestModularAddByNumber.Run(qsim, a, b, N).Result,
                        Math.Pow(2, N));
                }

                // Modulus Multiplication
                // Note : modulus and integer "a" must be co-prime.
                for (int a = 5, b = 3; b <= 7; b++)
                {
                    Console.WriteLine("{0} x {1} is {2} (mod {3})",
                        a,
                        b,
                        TestModularMultiply.Run(qsim, a, b, N).Result,
                        Math.Pow(2, N));
                }

                // Modulus Exponential
                // Note : modulus and integer "a" must be co-prime.
                for (int a = 3, b = 3; b <= 7; b++)
                {
                    Console.WriteLine("{0} ^ {1} is {2} (mod {3})",
                        a,
                        b,
                        TestModularExponent.Run(qsim, a, b, N).Result,
                        Math.Pow(2, N));
                }
            }

            Console.ReadLine();
        }
    }
}