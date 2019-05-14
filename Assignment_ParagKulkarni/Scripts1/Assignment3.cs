//Find the second maximum number from the list of  integers using LINQ. Order by and Sort By is not allowed.

using System;
using System.Collections.Generic;
namespace Scripts1
{
    public class Assignment3
    {
        public int findSecondMaxInt(List<int> list)
        {
            
            List<int> lst = new List<int>();
            int secondHighest = (from number in list
                             orderby number descending
                             select number).Distinct().Skip(1).First();
            return secondHighest;
        }

    }
}