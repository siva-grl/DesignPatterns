using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Functional
{
    public static class FunctionalExtensions
    {
        public static Func<T, T> AndThen<T>(this Func<T, T> first, Func<T, T> second)
        {
            return input => second(first(input));
        }
    }
}
