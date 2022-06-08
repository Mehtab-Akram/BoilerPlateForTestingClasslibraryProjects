using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public static class StringUtils
    {
        public static string ToAcronym(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return "";
            }
            List<string> inputList = str.Split(" ").ToList();

            return String.Join("", inputList.Select(x => x[0].ToString().ToUpper()));

        }
    }
}
