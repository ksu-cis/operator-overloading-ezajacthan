using System;

namespace VectorMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with vectors");

            Vector3 one = new Vector3(5, 4, 3);
            Vector3 two = new Vector3(2,8,6);

            Console.WriteLine("Adding two vectors: ");
            Console.WriteLine($"With a static method:\n {Vector3.Add(one, two)}");
            one.Add(two);
            Console.WriteLine($"With a class method:\n {one}");
            one = new Vector3(5, 4, 3);
            Console.WriteLine($"With operator overloading:\n {one + two}");

            Console.WriteLine($"Vector subtraction (one - two):\n {one - two}");

            Console.WriteLine($"Vector scaling (one * 10): \n {one * 10}");

            Console.WriteLine($"Vector comparison of one and two:\n {one == two}");
            Vector3 three = new Vector3(5, 4, 3);

            Console.WriteLine($"Vector comparison of one and three:\n {one == three}");

            if (one)
            {
                Console.WriteLine("Vector one is true and not zero");
            }
            else
            {
                Console.WriteLine("Vector one is zero and false");
            }

            Console.WriteLine("Vector one reassignment to <0,0,0>");
            one = new Vector3(0, 0, 0);

            if(one)
            {
                Console.WriteLine("Vector one is true and not zero");
            }
            else
            {
                Console.WriteLine("Vector one is zero and false");
            }
        }
    }
}
