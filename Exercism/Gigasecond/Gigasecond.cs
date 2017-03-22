using System;

namespace Exercism.Gigasecond
{
    public static class Gigasecond
    {
        public static DateTime Date(DateTime birthDate) => birthDate.AddSeconds(1000000000);
    }
}
