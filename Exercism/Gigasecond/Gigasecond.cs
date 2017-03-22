using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism.Gigasecond
{
    public static class Gigasecond
    {
        public static DateTime Date(DateTime birthDate)
        {
            return birthDate.AddSeconds(1000000000).ToUniversalTime();
        }
    }
}
