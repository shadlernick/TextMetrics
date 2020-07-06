using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TerrasoftTest.Metrics
{
    public class PunctSymbolsCountMetric : IMetric
    {
        public string GetMetricsResult(string a)
        {
            var totalLength = a.Length;
            
            Regex regex = new Regex("([?!:;,])");

            return "\n Punctuation symbols: " + (totalLength - regex.Replace(a, "").Length).ToString();
        }
    }
}
