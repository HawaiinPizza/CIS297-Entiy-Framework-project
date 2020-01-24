using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace January23rd
{
    public class LuckyNumbers : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
            yield return 5;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class Fibonacci : IEnumerable<int>
    {
        int previous;
        int current;

        public Fibonacci()
        {
            previous = 0;
            current = 1;
        }
        
        public IEnumerator<int> GetEnumerator()
        {
            int next;
            do
            {
                yield return current;
                next = current + previous;
                previous = current;
                current = next;
            } while (next > 0);
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    public abstract class Polygon
    {
        public int numberOfSides { get; private set;}
        protected int[] sideLengths;

        public Polygon(int numberOfSides)
        {
            this.numberOfSides = numberOfSides;
            sideLengths = new int[numberOfSides];
        }

        public virtual void setSideLength(int sideNumber, int sideLength)
        {
            if ( sideNumber < 0 || sideNumber >= sideLengths.Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            sideLengths[sideNumber] = sideLength;
        }

        public int getSideLength(int sideNumber)
        {
            if (sideNumber < 0 || sideNumber >= sideLengths.Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            return sideLengths[sideNumber];
        }

        public int GetPerimeter()
        {
            int perimeter = 0;
            foreach( var sideLength in sideLengths )
            {
                perimeter += sideLength;
            }
            return perimeter;
        }

        public abstract int getArea();
    }

    public class Rectangle : Polygon, IEquatable<Rectangle>, IComparable<Rectangle>
    {
        public Rectangle() : base(4)
        {
            // empty
        }

        public void setWidth(int width)
        {
            base.setSideLength(1, width);
            base.setSideLength(3, width);
        }

        public void setLength(int length)
        {
            base.setSideLength(0, length);
            base.setSideLength(2, length);
        }

        public override void setSideLength(int sideNumber, int sideLength)
        {
            throw new InvalidOperationException("You can't side just 1 side of a rectangle, it breaks the law");
        }

        public override int getArea()
        {
            return getSideLength(0) * getSideLength(1);
        }

        public bool Equals(Rectangle other)
        {
            return getSideLength(0) == other.getSideLength(0)
                && getSideLength(1) == other.getSideLength(1);
          
        }

        int IComparable<Rectangle>.CompareTo(Rectangle other)
        {
            return getArea() - other.getArea();
        }
    }
}
