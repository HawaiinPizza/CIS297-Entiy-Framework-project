using System;

namespace January9th
{
    enum DaysOfWeek {  Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
    
    class Program
    {
        static double DoSomeMath(int number)
        {
            return number * 1.1;
        }
        
        static void Main(string[] args)
        {

            var someInput = Console.ReadLine();
            
            var integerValue = Convert.ToInt32(someInput);

            var callMyFunction = DoSomeMath(integerValue);

            Console.WriteLine(integerValue * 10);

            var number = 10.1;

            bool someBoolean = true;

            int someBigInt = 123_456_789;

            // - and + have the same priority and go left to right
            int arithmeticIsHard = (1 - 3) + 6; // i think it's 4

            var positiveNumber = +3;

            int negagtiveNumber = -3;

            positiveNumber += 3;

            Console.WriteLine($"My positive number is {positiveNumber} it's a great number");

            Console.WriteLine($"4 / 6 == {arithmeticIsHard / positiveNumber}");

            Console.WriteLine($"100.0 / 0 * 0 == {100.0 / 0 * 0}");
            var something = false;
            var somethingElse = !something;

            // switching on strings is fun
            switch(someInput)
            {
                case "10":
                    Console.WriteLine(10);
                    break;
            }

            while (something)
            {
                Console.WriteLine("Hi there!");
            }

            do
            {
                Console.WriteLine("Hi there!");
            } while (something);

            for ( int index = 0; index < someInput.Length; index++)
            {
                Console.WriteLine(someInput[index]);
            }
            int[] numbers = { 1, 2, 3, 4, 5 };
            
            foreach( var value in numbers )
            {
                Console.WriteLine(value);
            }

            int[] variableLengthArray = new int[integerValue];

            var myTriangle = new Triangle();
            myTriangle.setBaseLength(10);
            myTriangle.setHeight(10);
            Console.WriteLine($"The area of my triangle is {myTriangle.getArea()}");
        }
    }
}
