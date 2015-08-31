using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasureTime
{
    public class TimeMeasurementBlock : IDisposable
    {
        public Stopwatch Stopwatch { get; private set; }

        public TimeMeasurementBlock(Stopwatch stopwatch)
        {
            Stopwatch = stopwatch;
            if(Stopwatch != null)
            {
                Stopwatch.Start();
            }
        }

        public void Dispose()
        {
            if(Stopwatch != null)
            {
                Stopwatch.Stop();
            }
        }
    }
}
