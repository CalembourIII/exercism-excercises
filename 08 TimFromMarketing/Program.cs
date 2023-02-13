using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_TimFromMarketing
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Print(null, "Amare Osei", null));
        }

        public static string Print(int? id, string name, string? department)
        {
            if (id == null)
            {
                if (department == null)
                {
                    return $"{name} - OWNER";
                }

                return $"{name} - {department.ToUpper()}";
            }

            if (department == null)
            {
                return $"[{id}] - {name} - OWNER";
            }

            else
                return $"[{id}] - {name} - {department.ToUpper()}";
        }
    }
}
