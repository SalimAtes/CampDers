using System;

namespace RefOutParameresi
{
    class Program
    {
        static void Main(string[] args)
        {
            //ref kullanımı
            //    int number1 = 10;
            //    int number2 = 15;
            //    var result = RefOut(ref number1, number2);
            //    Console.WriteLine(result) ;
            //    Console.WriteLine(number1);
            /////////////////////////////////
            ///out kullanımı
            int number1; // out parametresi oldugu için değer vermeyebiliriz...
            int number2 = 15;
            var result = OutRef(out number1,number2);
            Console.WriteLine(result);
            Console.WriteLine(number1);
            Console.WriteLine(multiplay(5,6));
            Console.WriteLine(multiplay(5,6,4));
            Console.WriteLine(ParamsP(5,6,4,8,7));


        }
        //ref kullanımı
        //static int RefOut(ref int number1, int number2)
        //{
        //    number1 = 100;
        //    return number1 + number2;

        //}
        ////////////////////////////////////////////////
        ///out kullanımı
        static int OutRef(out int number1,int number2)
        {
            number1 = 10;
            return number1 + number2;
        }

        static int multiplay(int number1, int number2)
        {
            return number1 * number2;
        }

        static int multiplay(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int ParamsP(params int[] numbers)
        {
            return numbers.Sum();
        }


    }
}
