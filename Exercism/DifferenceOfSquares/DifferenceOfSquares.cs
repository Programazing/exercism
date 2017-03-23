using System;
using System.Collections.Generic;
using System.Linq;

public static class Squares
{
    public static int SquareOfSums(int max) => Enumerable.Range(0, max + 1).Sum() * Enumerable.Range(0, max + 1).Sum();

    public static int SumOfSquares(int max)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public static int DifferenceOfSquares(int max)
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}