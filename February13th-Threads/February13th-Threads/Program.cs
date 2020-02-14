using System;
using System.Threading;
using System.Threading.Tasks;

namespace February13th_Threads
{

    public class Values
    {
        public string Value { get; set; }
    }
    public class HoldsValues
    {
        public Values value1 { get;set;}
        public Values value2 { get; set; }

        public HoldsValues()
        {
            value1 = null;
            value2 = new Values() { Value = "Hi there" };

        }

    }

    public class Program
    {
        private static string numberOfTimesYouCalledMe = "";
        private static object threadLock = new object();
        
        public static void FibonacciTo1000000000(object input)
        {
            var threadNumber = (int)input;
            var current = 1;
            var previous = 0;
            while ( current < 1_000_000_000 )
            {
                Console.WriteLine($"Thread #{threadNumber} here - currently on {current}");
                var next = current + previous;
                previous = current;
                current = next;
            }
        }

        public static void LogNumberOfTimesYouRanThis(object input)
        {
            var threadNumber = (int)input;
            lock(threadLock)
            {
                numberOfTimesYouCalledMe += threadNumber.ToString();
            }
            
            Console.WriteLine($"{threadNumber} {numberOfTimesYouCalledMe}");
        }

        public static Task printNonsense()
        {
            return Task.Run(() => { for (int number = 0; number < 100; number++)
                {
                    Console.WriteLine("asdfasd");
                }
            });
        }

        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //for (int threadCount = 0; threadCount < 100; threadCount++)
            //{
            //    Thread thread = new Thread(LogNumberOfTimesYouRanThis);
            //    thread.Start(threadCount);
            //}
            //CallNonsense();



            int? isNumberOrNot = null;
            // cant do this: int isNumber = null;
            if ( isNumberOrNot.HasValue)
            {
                Console.WriteLine(isNumberOrNot.Value);
            }
            HoldsValues values = new HoldsValues();
            Console.WriteLine($"Value1: {values?.value1?.Value}");
            if ( values.value2 != null )
            {
                Console.WriteLine($"Value2: {values.value2.Value}");
            }
            Console.WriteLine($"Value2: {values?.value2.Value}");

            HoldsValues moreValues = new HoldsValues();
            
            if ( moreValues.GetType() == typeof(HoldsValues))
            {
                Type moreValuesType = moreValues.GetType();
                var moreValueConstuctors = moreValuesType.GetConstructors();
                var newObject = moreValueConstuctors[0].Invoke(new object[] { });
                Console.WriteLine(newObject.ToString());
                Console.WriteLine("This is more values!");

            }
            Console.WriteLine(typeof(HoldsValues));



        }

       

        public static async void CallNonsense()
        {
            Console.WriteLine("Started");
            await printNonsense();
            Console.WriteLine("After printing nonsense");
        }
    }
}
