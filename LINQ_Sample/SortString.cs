using System.Collections.Generic;

namespace LINQ_Sample
{
    public class SortString : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y,true);
        }
    }
}