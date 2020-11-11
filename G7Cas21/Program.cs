using System;

namespace G7Cas21
{
    class Program
    {
        static void Main(string[] args)
        {
            // *** while
            Console.WriteLine("*** Loops | while ***");
            int a = 10;

            while(a < 20)
            {
                Console.WriteLine("while | a = {0}", a);
                a++;
            }

            Console.WriteLine("Out of the loop.");

            // *** for
            Console.WriteLine("*** Loops | for ***");
            for (int i = 0; i < 50; i = i + 5)
            {
                Console.WriteLine("for loop | i = {0}", i);
            }

            // *** do .. while
            Console.WriteLine("*** Loops | do .. while ***");
            int b = 10;

            do
            {
                Console.WriteLine("do..while | b = {0}", b);
                b++;
            } while (b < 20);


            Console.WriteLine("*** Methods/functions ***");
            Console.WriteLine("Unesite dva broja za poredjenje.");

            Console.Write("Broj 1 >");
            int in1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Broj 2 >");
            int in2 = Convert.ToInt32(Console.ReadLine());
            int result = FindGreater(in1, in2);
            Console.WriteLine("Veci broj je: {0}", result);

            Console.WriteLine("*** Methods/functions - Recursion ***");
            
            int num;
            GetUserInput("Unesite broj za koji cemo racunati faktorijel", out num);

            Console.WriteLine("Factorial of {0} = {1}", num, Factorial(num));

            Console.WriteLine("*** Methods/functions - Passing params by value/reference ***");

            int x = 100;
            int y = 200;
            Console.WriteLine("Pre zamene, x = {0}", x);
            Console.WriteLine("Pre zamene, y = {0}", y);
            Swap(ref x, ref y);
            Console.WriteLine("Nakon zamene, x = {0}", x);
            Console.WriteLine("Nakon zamene, y = {0}", y);

            Console.WriteLine("*** Methods/functions - output parameters ***");
            int n = 1;
            Console.WriteLine("Pre poziva GetValue(), vrednost n = {0}", n);

            GetValue(out n);

            Console.WriteLine("Nakon poziva GetValue(), vrednost n = {0}", n);

            Console.WriteLine("Kvadrat 2 je {0}", Kvadrat(2));

            Console.WriteLine("2^3 = {0}", Math.Pow(2, 3));
            
            Console.ReadKey();

        }

        public static int FindGreater(int num1, int num2)
        {
            int result;

            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }

            return result;
        }

        public static int Factorial(int num)
        {
            int result;

            if (num == 1)
            {
                return 1;
            } else
            {
                result = Factorial(num - 1) * num;
                return result;
            }
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp;

            temp = a;
            a = b;
            b = temp;
        }

        public static void GetValue(out int x)
        {
            x = 5;
        }
        
        public static void GetUserInput(string message, out int a)
        {
            Console.Write("{0} >", message);
            a = Convert.ToInt32(Console.ReadLine());
        }

        public static int Kvadrat(int num)
        {
            int result;
            result = num * num;
            return result;
        }
    }
}
