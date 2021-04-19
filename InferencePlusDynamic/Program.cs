
using System;

namespace InferencePlusDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = 5;
            var school = "TreinaWeb";
            StringUtils utils = new StringUtils();
            var number1Type = utils.GetVarType(number1);
            var schoolType = utils.GetVarType(school);
            Console.WriteLine(number1Type + " = " + number1);
            Console.WriteLine(schoolType + " = " + school);

            dynamic value = 2;
            var valueType = utils.GetVarType(value);
            Console.WriteLine(valueType + " = " + value);
            value = "Test it out :v";
            valueType = utils.GetVarType(value);
            Console.WriteLine(valueType + " = " + value);
        }

    }

    class StringUtils
    {
        public String GetVarType(dynamic variable)
        {
            return variable.GetType().ToString().Substring(7);
        }

    }
    
}
