using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public static class Analysis
    {
        public static Findings getStats(List<decimal> lstDecimals)
        {
            Findings output = new Findings();

            if (lstDecimals.Count > 0)
            {
                if (lstDecimals.Count == 1)
                {
                    output.min = output.max = output.average = lstDecimals[0];
                }
                else
                {
                    output.min = lstDecimals.Min();
                    output.max = lstDecimals.Max();
                    output.average = lstDecimals.Average();

                }
            }

            return output;
        }
    }
    public struct Findings
    {
        public decimal max;
        public decimal min;
        public decimal average;

    }
}
