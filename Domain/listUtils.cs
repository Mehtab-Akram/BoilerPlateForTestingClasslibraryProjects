using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public static class listUtils
    {
        public static List<object> Diff(ArrayList lst1, ArrayList lst2)
        {
            if (lst1.Count == 0 && lst2.ToArray().Where(x => !string.IsNullOrWhiteSpace(x.ToString())).Count() == 0)
                return new List<object>();
            return lst1.ToArray().Except(lst2.ToArray()).ToList();

        }

    }
}
