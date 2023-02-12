using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LogAnalysis
{
    internal class LogAnalysis
    {
        // TODO: define the 'SubstringAfter()' extension method on the `string` type
        public static string SubstringAfter(this string str, string after)
        {
            int startAt = str.IndexOf(after) + after.Length;
            return str.Substring(startAt);
        }
        // TODO: define the 'SubstringBetween()' extension method on the `string` type
        public static string SubstringBetween(this string str, string start, string finish)
        {
            int startAt = str.IndexOf(start) + start.Length;
            int finishAt = str.IndexOf(finish) - startAt;
            return str.Substring(startAt, finishAt);
        }

        // TODO: define the 'Message()' extension method on the `string` type
        public static string Message(this string str) => str.SubstringAfter(": ");
        // TODO: define the 'LogLevel()' extension method on the `string` type
        public static string LogLevel(this string str) => str.SubstringBetween("[", "]");
    }
}
