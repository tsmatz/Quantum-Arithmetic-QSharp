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
                int n = 3; // N = 2^n

                // Modulus Addition
                for (int a = 3, b = 3; a <= 7; a++)
                {
                    Console.WriteLine("{0} + {1} is {2} (mod {3})",
                        a,
                        b,
                        TestQuantumAdd.Run(qsim, a, b, n).Result,
                        Math.Pow(2, n));
                }
                for (int a = 7, b = 4; b <= 7; b++)
                {
                    Console.WriteLine("{0} + {1} is {2} (mod {3})",
                        a,
                        b,
                        TestQuantumAdd.Run(qsim, a, b, n).Result,
                        Math.Pow(2, n));
                }

                // Modulus Subtraction
                for (int a = 3, b = 5; a <= 7; a++)
                {
                    Console.WriteLine("{0} - {1} is {2} (mod {3})",
                        b,
                        a,
                        TestQuantumSub.Run(qsim, a, b, n).Result,
                        Math.Pow(2, n));
                }

                // Modulus Addition by Classical Numeric
                for (int a = 3, b = 3; a <= 7; a++)
                {
                    Console.WriteLine("{0} + {1} is {2} (mod {3})",
                        a,
                        b,
                        TestQuantumAddByNumber.Run(qsim, a, b, n).Result,
                        Math.Pow(2, n));
                }
                for (int a = 7, b = 4; b <= 7; b++)
                {
                    Console.WriteLine("{0} + {1} is {2} (mod {3})",
                        a,
                        b,
                        TestQuantumAddByNumber.Run(qsim, a, b, n).Result,
                        Math.Pow(2, n));
                }

                // Modulus Multiplication
                // Note : modulus and integer "a" must be co-prime.
                for (int a = 5, b = 3; b <= 7; b++)
                {
                    Console.WriteLine("{0} x {1} is {2} (mod {3})",
                        a,
                        b,
                        TestQuantumMultiply.Run(qsim, a, b, n).Result,
                        Math.Pow(2, n));
                }

                // Modulus Exponential
                // Note : modulus and integer "a" must be co-prime.
                for (int a = 3, b = 3; b <= 7; b++)
                {
                    Console.WriteLine("{0} ^ {1} is {2} (mod {3})",
                        a,
                        b,
                        TestQuantumExponent.Run(qsim, a, b, n).Result,
                        Math.Pow(2, n));
                }
            }

            Console.ReadLine();
        }
    }
}