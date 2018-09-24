using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Kevin";
            bool isWorking = true;

            // Can also be written as Var

            // var number = 2;
            // var count = 10;
            // var totalPrice = 20.95f;
            // var character = 'A';
            // var firstName = "Kevin";
            // var isWorking = true;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
        }

        static void Two(string[] args)
        {
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
        }

        static void Three(string[] args)
        {
            const float Pi = 3.14f;
        }

    }
}
