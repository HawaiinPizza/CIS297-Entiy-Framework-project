using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;
using FooFromFooBar = AnotherFooBarNamespace.Foo;


namespace February6thAdvancedTopics
{

    public delegate int MathDelegate(int a, int b);
    class QuadraticRoots
    {
        public double first { get; set;}
        public double second { get; set; }
    }
    
    public static class StringExtensions
    {
        public static string ToRandomCase(this string test)
        {
            string newString = "";
            for (int index = 0; index < test.Length; index++)
            {
                if (test[index] == 'A')
                {
                    newString += 'a';
                }
                else
                {
                    newString += test[index];
                }
            }
            return newString;
        }
    }
    
    
    class Program
    {
        

        Func<int, int, int> someMath = Subtract;

        public static int Add( int a, int b)
        {
            return a + b;
        }

        public static int Subtract( int a, int b)
        {
            return a - b;
        }
        static QuadraticRoots findRoots(double a, double b, double c)
        {
            return new QuadraticRoots() { first = 1, second = 2 };
        }

        static Tuple<double, double> findRootsTuple( double a, double b, double c)
        {
            return new Tuple<double, double> ( 1, 2 );
        }
        
        static int multiply(int a )
        {
            return multiply(a, 1);
        }
        static int multiply( int a, int b = 1, int c = 2)
        {
            return a * b * c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(File.ReadAllText("somefile.txt"));
            File.WriteAllText("somenewfile.txt", "more junk".ToRandomCase());

            MathDelegate someOperation = Add;

            someOperation(2, 4);

            List<int> numbers = new List<int> { 1, 2, 3 };

            if ( numbers is IEnumerable<int>)
            {

            }
            
            multiply( c: 5, a:2);

            string input = Console.ReadLine();
            
            if ( double.TryParse(input, out double result) )
            {
                Console.WriteLine(result * 10);
            }

            WriteLine("Hello World!");
        }
    }
}

namespace Namespace1
{
    public class Foo
        {

        }
}

namespace AnotherFooBarNamespace
{
    public class Foo
    {

    }
}

