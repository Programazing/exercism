using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism.DifferenceOfSquaresTests
{
    public static class Squares
    {
        public static double SquareOfSums(int max) => Math.Pow(Enumerable.Range(1, max).Sum(), 2);

        public static double SumOfSquares(int max) => Enumerable.Range(1, max).Select(n => n * n).Sum();

        public static double DifferenceOfSquares(int max) => SquareOfSums(max) - SumOfSquares(max);
    } 
}