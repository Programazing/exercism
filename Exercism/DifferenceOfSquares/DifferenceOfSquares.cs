using System;
using System.Collections.Generic;
using System.Linq;

public static class Squares
{
    public static double SquareOfSums(int max) => Math.Pow(Enumerable.Range(1, max).Sum(), 2);

    public static double SumOfSquares(int max)
    {
        var range = Enumerable.Range(1, max);
        Double sum = 0.0;


        foreach (var number in range)
        {

            sum += Math.Pow(number, 2);
        }

        return sum;
    }

    public static int DifferenceOfSquares(int max)
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}