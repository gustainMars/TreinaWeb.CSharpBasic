using System;
using System.Text;

namespace StudyingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "Gustavo";
            String lastName = "Marques";
            StringBuilder sb = new StringBuilder();

            sb.Append(name);
            sb.Append(" ");
            sb.Append(lastName);

            Console.WriteLine(sb.ToString());
        }
    }
}
