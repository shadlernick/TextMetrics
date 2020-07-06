using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TerrasoftTest.Metrics;
using Newtonsoft.Json;

namespace TerrasoftTest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TextMetricController : ControllerBase
    {
        private List<IMetric> _metrics;

        public TextMetricController()
        {
            _metrics = new List<IMetric>();
            _metrics.Add(new MostFrequentSymbolMetric());
            _metrics.Add(new PunctSymbolsCountMetric());
            _metrics.Add(new SymbolsCountMetric());
        }

        [HttpGet]
        public string GetMetrics()
        {
            return "Hello API!";
        }

        [HttpPost]
        public Input SetText(Input input)
        {
            string temp = null;

            foreach (var t in _metrics)
            {
                temp += t.GetMetricsResult(input.text);
            }

            input.text = temp;

            return input;
        }
    }
}