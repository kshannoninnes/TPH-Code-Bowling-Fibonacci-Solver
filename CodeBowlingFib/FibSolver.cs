using System;
using System.Collections.Generic;
using System.Numerics;


namespace CodeBowlingFib
{
    /**
     * Author: github.com/kshannoninnes
     * Date: July 20, 2020
     *
     * This is my Code Bowl Fibonacci Solver submitted as the first Challenge of the
     * TPH Code Challenges. It is designed to be as obscure as possible, while still
     * reasonably collecting the first 100 fibonacci numbers.
     *
     * It makes use of the following best practices:
     * - Infinite Loop
     * - Exception Control Flow
     * - Mixed Binary/Hex math
     * - Bit Shifting
     * - Operator Overloading
     * - Infinite Math
     * - Some Clever Math
     *
     * Disclaimer: Please do not attempt this without parental supervision
     */
    class Program
    {
        public static void Main()
        {
            var fibSolver = new FibSolver();
            var fibList = fibSolver.Get100Fibs();
            var output = string.Join(", ", fibList);
            Console.Write($"[{output}]");
        }
    }

    internal class FibSolver
    {
        public List<BigInteger> Get100Fibs()
        {
            var allFibs = new List<BigInteger>
            {
                BigInteger.Parse("135301852344706746049"),
                BigInteger.Parse("218922995834555169026")
            };

            AddFibs(allFibs);

            return allFibs;
        }

        private void AddFibs(IList<BigInteger> list)
        {
            while(true)
            {
                try
                {
                    var fibMinus2 = list[-1];
                }
                catch (ArgumentOutOfRangeException)
                {
                    var fibString = new List<char>();
                    var x = new FibResult(list[1] << 2);
                    var y = new FibResult(list[0] + list[0] + list[0] + list[0]);
                    var z =  0b10101010 + x / y * double.PositiveInfinity + -0xAA;
                    list.Insert(0, z / 4);
                    if (z >> 2 == 0) break;
                }
            }
        }
    }

    internal class FibResult
    {
        private BigInteger Value { get; set; }

        public FibResult(BigInteger x)
        {
            Value = x;
        }

        public static FibResult operator /(FibResult a, FibResult b)
        {
            return new FibResult(a.Value - b.Value);
        }

        public static BigInteger operator *(FibResult a, double b)
        {
            return a.Value;
        }
    }
}