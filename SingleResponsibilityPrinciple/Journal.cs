using System;
using System.Collections.Generic;

namespace SingleResponsibilityPrinciple
{
    public class Journal
    {
        private readonly List<string> entries = new List<string>();

        private static int count = 0;

        public int Add(string text)
        {
            entries.Add($"{++count}: {text}");
            return count; // momento 
        }

        public void Remove(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }
    }
}
