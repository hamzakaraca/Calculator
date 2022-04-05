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
            Console.WriteLine("1-Add Function");
            Console.WriteLine("2-Division Function");
            string a = Console.ReadLine();
            switch (Convert.ToInt32(a))
            {
                case 1:
                    Add(Convert.ToInt32(number1), Convert.ToInt32(number2));
                    break;


                case 2:
                    Division(Convert.ToDecimal(number1), Convert.ToDecimal(number2));
                    break;

            }
            
        }
        public static void  Add(int number1,int number2)
        {
            int result = number1 + number2;
            Console.WriteLine("Result:" + result);
        }
        public static void Division(Decimal number1,Decimal number2)
        {
            Decimal result = number1 / number2;
            Console.WriteLine("Result:" + result);
        }
    }
}
