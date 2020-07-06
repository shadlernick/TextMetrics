using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TerrasoftTest.Metrics
{
    public class MostFrequentSymbolMetric : IMetric
    {

        public string GetMetricsResult(string a)
        {
            var arr = a.Replace(" ", "").ToCharArray();
            char cmx = ' '; //most frequent char
            int mx = 0; //how much time

            List<char> list = new List<char>();



            for (int i = 0; i < arr.Length - 1; i++) 
            {
                var c = arr[i];
                var k = 1;

                if(list.IndexOf(c) == -1) 
                {
                    list.Add(c);
                    for(int j = i+1; j< arr.Length; j++)
                    {
                        if(arr[j] == c)
                            k++;
                    }
                    if (k > mx) {
                        mx = k;
                        cmx = c;
                    }
                }
            }

            return "The most frequent symbol: " + cmx.ToString() + ", " + mx.ToString() + " times";
        }
    }
}
