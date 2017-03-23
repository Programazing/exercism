using System;
using System.Collections.Generic;
using System.Linq;

public static class Squares
{
    public static double SquareOfSums(int max) => Math.Pow(Enumerable.Range(1, max).Sum(), 2);

    public static int SumOfSquares(int max)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public static int DifferenceOfSquares(int max)
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}