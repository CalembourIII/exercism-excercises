using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LogAnalysis
{
    internal class LogAnalysis
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SubstringAfter("[INFO]: File Deleted."));
            //Console.WriteLine(LogLevel("[ERROR]: Invalid operation"));
            //Console.WriteLine(Reformat("[INFO]: Operation completed"));
        }

        // TODO: define the 'SubstringAfter()' extension method on the `string` type
        static string SubstringAfter(string log)
        {
            string c = log.SubstringAfter();
            return log.SubstringAfter(":");

            string[] a = log.Split(':');
            string b = a[1].Trim();
            return $"\"{b}\"";


            //int message = log.IndexOf(": ") + ": ".Length;
            //return log.Substring(message).Trim();
        }

        // TODO: define the 'SubstringBetween()' extension method on the `string` type

        // TODO: define the 'Message()' extension method on the `string` type

        // TODO: define the 'LogLevel()' extension method on the `string` type

    }
}
