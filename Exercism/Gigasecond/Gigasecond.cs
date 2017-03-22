using System;

namespace Exercism.Gigasecond
{
    public static class Gigasecond
    {
        public static DateTime AddGigasecond(DateTime birthDate) => birthDate.AddSeconds(1000000000);
    }
}
