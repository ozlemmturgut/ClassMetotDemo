using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //Add();
            //int result1 = Add2();
            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(number1, number2);
            Console.WriteLine(result2);
            Console.WriteLine(number1); // number1 = 20
            Console.ReadLine();
            
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        //default değerler her zaman metotun sonunda olması lazım.
        //birden fazla default değer verilebilir
        static int Add2(int number1 = 20, int number2 = 30)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
    }
}
