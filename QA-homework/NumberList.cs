using System;
using System.Collections.Generic;
using System.Linq;

namespace QAhomework
{
    public class NumberList
    {
        List<long> numbers = new List<long>();

        public NumberList()
        {
        }

        public void Add(long item)
        {
            numbers.Add(item);
        }

        public string Print()
        {
            if (numbers.Count == 0)
            {
                return "The collection is empty";
            }

            return String.Join("\n", numbers);
        }

        private long Sum()
        {
            return numbers.Sum();
        }

        public long Divide(int divider)
        {
            return Sum() / divider;
        }

        public long Count()
        {
            return numbers.Count;
        }

        public void Clear()
        {
            numbers.Clear();
        }
    }
}
