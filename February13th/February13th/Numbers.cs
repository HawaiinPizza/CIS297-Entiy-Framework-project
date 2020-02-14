using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace February13th
{
    public class Numbers
    {
        public int Number1 { get; private set; }
        public int Number2 { get; private set; }
        public int Number3 { get; private set; }
        public int Number4 { get; private set; }
        public int Number5 { get; private set; }

        private Random random;

        public List<Tuple<int, int>> combinations { get; set; }

        public Numbers()
        {
            random = new Random();
            combinations = new List<Tuple<int, int>>();
            ChangeNumbers();
        }

        public void ChangeNumbers()
        {
            Number1 = random.Next(1, 66);
            Number2 = random.Next(1, 66);
            Number3 = random.Next(1, 66);
            Number4 = random.Next(1, 66);
            Number5 = random.Next(1, 66);
            if (NumbersChanged != null)
            {
                NumbersChanged(this, EventArgs.Empty);
            }

            for( int number = 1; number < 45; number++)
            {
                for( int secondNumber = number +1; secondNumber <= 45; secondNumber++)
                {
                    combinations.Add(new Tuple<int, int>(number, secondNumber));
                }
            }

            List<int> lotsOfNumbers = new List<int>();
            for( int number =1; number< 100; number++)
            {
                lotsOfNumbers.Add(number);
            }

            List<int> evenNumbers = lotsOfNumbers.Where(number => number % 2 == 0).ToList();
            IEnumerable<int> queryWithouLambdaEvenNumbers = from number in lotsOfNumbers
                                                            where number % 2 == 0
                                                            select number;


              IEnumerable < Tuple<int, int> > result = from pair in combinations
                                                       where pair.Item1 == 3
                                                       select pair;

            IEnumerable<string> stringyResult = from pair in combinations
                                         where pair.Item1 == 3
                                         let sum = pair.Item2 + pair.Item1
                                         select $"The sum of {pair.Item1} and {pair.Item2} is { sum }";




            List<Tuple<int, int>> longerResult = new List<Tuple<int, int>>();
            foreach( var pair in combinations)
            {
                if ( pair.Item1 == 3)
                {
                    longerResult.Add(pair);
                }
            }


        }

        public event EventHandler NumbersChanged;

    }
}
