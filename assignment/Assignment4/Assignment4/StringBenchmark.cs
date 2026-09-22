using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Assignment4
{
    [MemoryDiagnoser]
  public class StringBenchmark
    {
        //string[] sessionNames =
        //                       {
        //                        "C# Basics",
        //                        "Arrays",
        //                        "Functions",
        //                        "Date and Time",
        //                        "Exception Handling"
        //                        };
        // DateTime[] sessionDates =
        //                         {
        //                                new DateTime(2026, 9, 10, 18, 0, 0),
        //                                new DateTime(2026, 9, 13, 18, 0, 0),
        //                                new DateTime(2026, 9, 17, 18, 0, 0),
        //                                new DateTime(2026, 9, 20, 18, 0, 0),
        //                                new DateTime(2026, 9, 24, 18, 0, 0)
        //                            };
        // int[] sessionDurations =
        //     {

        //                            180,
        //                            240,
        //                            180,
        //                            240,
        //                            180
        //        };
        [Params(100, 1000, 10000, 100000)]
        public int Iterations;


        private const string Text = "Session - 10/09/2026 06:00 PM - 180 minutes";

        [Benchmark]
        public  string BuildScheduleReport()
        {
            string result = "";
            for (int i = 0; i < Iterations; i++)
            {
                result += Text;

            }
           return result;

        }

        [Benchmark]
        public  string ReportUsingStringBuilder()
        {
            
            StringBuilder result = new StringBuilder("");
            for (int i = 0; i < Iterations; i++)
            {
                result.Append(Text);
                

            }
            return result.ToString();

        }



    }
}
