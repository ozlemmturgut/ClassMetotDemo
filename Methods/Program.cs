using System;
using System.Linq;

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
            //int number1 = 20;
            //int number2 = 100;
            ////var result2 = Add3(ref number1, number2);
            //var result2 = Add3(out number1, number2);
            //Console.WriteLine(result2);
            //Console.WriteLine(number1); // number1 = 20 --> ref olunca number1 = 30
            
            // ref -> number1 !ın ilk değerinin plması lazım
            // out'ta böyle bir zorunluluk yok


            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2,4,5));

            Console.WriteLine(Add4(1,2,3,4,5,6));

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

        /*static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }*/

        static int Add3(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        // Farklı parametreler ama aynı metot ismi --> Method Overloading
        static int Multiply(int number1, int number2) //Metodun imzası
        {
            return number1 * number2;
         }

        static int Multiply(int number1, int number2, int number3) 
        {
            return number1 * number2 * number3;
        }
        // aynı tipte istediğimiz kadar parametre gönderebiliriz --> params
        //params son parametre olmak zorunda
        static int Add4(int number, params int[] numbers)
        {
            return numbers.Sum();
        }




    }
}
