using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            coolConsolePrint cool = new coolConsolePrint();
            Console.WriteLine("Write down what do you like to print:");
            string thingToWrite = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(cool.printWord(thingToWrite));
            Console.ReadLine();
        }
    }

    public class coolConsolePrint
    {
        public string printWord(String word)
        {
            string style = "==========";
            int style_size = style.Length;
            int content_size = word.Length;
            int padding_size = 2; // makes sure that content does not sit right against style
            int line_size = content_size + (style_size * 2) + (padding_size * 2);

            string enclosing_line =
              style.PadRight(line_size, '=')
              + Environment.NewLine;

            string content_line =
              style.PadRight(style_size + padding_size)
              + word
              + style.PadLeft(style_size + padding_size)
              + Environment.NewLine;

            return enclosing_line + content_line + enclosing_line;
        }
        
    }
}
