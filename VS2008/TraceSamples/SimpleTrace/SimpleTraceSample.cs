// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SimpleTraceSample.cs" company="Say No More">
//   2009
// </copyright>
// <summary>
//   Simple Trace Sample.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SimpleTrace
{
    using System;
    using System.Diagnostics;
    using System.Threading;
    using System.Linq;
    using System.Linq.Expressions;

    /// <summary>
    /// Simple Trace Sample.
    /// </summary>
    public class SimpleTraceSample
    {
        /// <summary>
        /// Entry point of Application.
        /// </summary>
        /// <param name="args">Start arguments.</param>
        public static void Main(string[] args)
        {
            var thread = new Thread(TraceSamples) { IsBackground = true };
            thread.Start();

            Console.Write("Press enter to stop...");
            Console.ReadLine();
        }

        /// <summary>
        /// Prints periodically traces.
        /// </summary>
        public static void TraceSamples()
        {
            while (true)
            {
                Trace.WriteLine("Test Trace");
                Trace.TraceError("Test Error");
                Trace.TraceInformation("Test Information");
                Debug.WriteLine("Test Debug");
                Thread.Sleep(1000);
            }
        }
    }
}
