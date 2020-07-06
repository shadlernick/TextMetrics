using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TerrasoftTest.Metrics
{
    public class SymbolsCountMetric : IMetric
    {
        public string GetMetricsResult(string a)
        {
            return "\n Text length: " + a.Length.ToString();
        }
    }
}
