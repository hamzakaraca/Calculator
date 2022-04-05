using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plaese Enter The First Number");
            string number1 = Console.ReadLine();
            Console.WriteLine("Plaese Enter Other Number");
            string number2 = Console.ReadLine();

            Add(Convert.ToInt32(number1),Convert.ToInt32(number2));
        }
        public static void  Add(int number1,int number2)
        {
            int result = number1 + number2;
            Console.WriteLine("Result:" + result);
        }
    }
}
