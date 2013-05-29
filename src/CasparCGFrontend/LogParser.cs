using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CasparCGFrontend
{
    public class LogParser
    {
        public static string ParseServerVersion(string data)
        {
            return string.Format("{0} {1}", data.Split(' ')[14], data.Split(' ')[15]);
        }

        public static string ParseComponentVersion(string data)
        {
            return string.Format("{0}", data.Split(' ')[8]);
        }
    }
}
