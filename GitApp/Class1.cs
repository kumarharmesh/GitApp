using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitApp
{
    class DateClass
    {
        public static string GetDate()
        {
            return DateTime.Now.ToString();
        }
        public static string GetFormattedDate(string format)
        {
            return DateTime.Now.ToString(format);

        }
        public static double RandomNumber()
        {
            var r = new Random();
            return r.NextDouble();
        }
        public string Number()
        {
            return "Hello world";
        }
        public static double Root(int n)
        {
           double x= Math.Sqrt(n);
            return x;
        }
    }
}
