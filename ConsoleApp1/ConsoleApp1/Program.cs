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
            Console.WriteLine(Pi);
        }

        static void Four(string[] args)
        {
            int i = 1;
            byte b = (byte) i;
            Console.WriteLine(b);
        }
        
        static void Five(string[] args)
        {
            var number = "1234";
            int i = Convert.ToInt32(number);
            Console.WriteLine(i);
        }

        static void Six(string[] args)
        {
            try
            {
                var number = "1234";
                int i = Convert.ToInt32(number);
                Console.WriteLine(i);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to an integer.");
            }
        }

        static void Seven(string[] args)
        {
            var a = 10;
            var b = 3;


            Console.WriteLine(a + b);
            Console.WriteLine(a / b);
            Console.WriteLine((float)a / (float)b);
        }
    }
}
