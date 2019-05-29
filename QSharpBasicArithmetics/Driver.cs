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

                // Addition
                Console.WriteLine("QuantumAdd");
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

                // Subtraction
                Console.WriteLine("Adjoint QuantumAdd");
                for (int a = 3, b = 5; a <= 7; a++)
                {
                    Console.WriteLine("{0} - {1} is {2} (mod {3})",
                        b,
                        a,
                        TestQuantumSub.Run(qsim, a, b, n).Result,
                        Math.Pow(2, n));
                }

                // Addition by Classical Numeric
                Console.WriteLine("QuantumAddByNumber");
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

                // Multiplication
                // Note : modulus and integer "a" must be co-prime.
                Console.WriteLine("QuantumMultiply");
                for (int a = 5, b = 3; b <= 7; b++)
                {
                    Console.WriteLine("{0} x {1} is {2} (mod {3})",
                        a,
                        b,
                        TestQuantumMultiply.Run(qsim, a, b, n).Result,
                        Math.Pow(2, n));
                }

                // Exponential
                // Note : modulus and integer "a" must be co-prime.
                Console.WriteLine("QuantumExponent");
                for (int a = 3, b = 3; b <= 7; b++)
                {
                    Console.WriteLine("{0} ^ {1} is {2} (mod {3})",
                        a,
                        b,
                        TestQuantumExponent.Run(qsim, a, b, n).Result,
                        Math.Pow(2, n));
                }

                // Addition By Modulus N
                Console.WriteLine("QuantumAddByModulus");
                int N = 7;
                for (int a = 3, b = 3; b <= 6; b++)
                {
                    Console.WriteLine("{0} + {1} is {2} (mod {3})",
                        a,
                        b,
                        TestQuantumAddByModulus.Run(qsim, a, b, n, N).Result,
                        N);
                }
            }

            Console.ReadLine();
        }
    }
}