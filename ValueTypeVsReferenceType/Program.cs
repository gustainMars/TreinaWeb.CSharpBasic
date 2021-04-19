using System;

namespace ValueTypeVsReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {            
            //Value pass
            int number1 = 3;
            int number2 = number1;
            number1 = 5;
            Console.WriteLine("Number 1 = {0},\nNumber 2 = {1}", number1, number2);
            
            //Reference pass
            Test test1 = new Test();
            test1.quantity = 3;
            Test test2 = test1;
            test1.quantity = 5;
            Console.WriteLine("\nQuantity Test 1 = {0},\nQuantity Test 2 = {1}", test1.quantity, test2.quantity);
            Console.ReadKey();            
        }
    }

    class Test
    {
        public int quantity;
    }
}
