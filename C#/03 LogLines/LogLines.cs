using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    internal class LogLines
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Message("[ERROR]: Invalid operation"));
            Console.WriteLine(LogLevel("[ERROR]: Invalid operation"));
            Console.WriteLine(Reformat("[INFO]: Operation completed"));
        }
        public static string Message(string logLine)
        {
            int message = logLine.IndexOf("]: ") + "]: ".Length;
            return logLine.Substring(message).Trim();
        }

        public static string LogLevel(string logLine)
        {
            int first = logLine.IndexOf("[") + "[".Length;
            int last = logLine.LastIndexOf("]");
            string LogLevelInLowerCase = logLine.Substring(first, last - first).ToLower();
            return LogLevelInLowerCase;
        }

        public static string Reformat(string logLine)
        {
            int message = logLine.IndexOf("]: ") + "]: ".Length;
            int first = logLine.IndexOf("[") + "[".Length;
            int last = logLine.LastIndexOf("]");
            string reformat = $"{logLine.Substring(message).Trim()} ({logLine.Substring(first, last - first).ToLower()})";
            return reformat;
        }
    }
}
